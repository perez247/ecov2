import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { CustomValidator } from 'app/shared/validators/custom-validators';
import { AuthService } from 'app/shared/services/auth/auth.service';
import { finalize } from 'rxjs/operators';
import { Router, ActivatedRoute } from '@angular/router';
import { ServerError } from 'app/shared/interceptors/form-error-handler';
import { FormErrorService } from 'app/shared/services/form-error/form-error.service';
import { NgRedux } from '@angular-redux/store';
import { IAppState } from 'app/shared/state-management/store';
import { UserActionConstant } from 'app/shared/state-management/user-state/user-action-constant';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.scss']
})

export class SigninComponent implements OnInit {

  signInForm: FormGroup;
  loading = false;

  returnUrl: string;

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private router: Router,
    private route: ActivatedRoute,
    private feService: FormErrorService,
    private redux: NgRedux<IAppState>
  ) { }

  ngOnInit() {
    this.initializeForm();
    this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || 'private';
  }

  initializeForm() {
    this.signInForm = this.fb.group({
      emailAddress : [null, [CustomValidator.CustomRequired('Email'), CustomValidator.CustomEmail()]],
      password: [null, CustomValidator.CustomRequired('Password')],
      rememberMe: [null]
    })
  }

  signIn() {

    this.loading = true;

    this.authService.signinUser(this.signInForm.value)
      .pipe(finalize(() => this.loading = false))
      .subscribe((data: any) => {

        // console.log(token);

        this.redux.dispatch({ type: UserActionConstant.SAVE_AUTH_USER, token : data.token })
        this.router.navigate([this.returnUrl]);

      },
        (error) => {this.feService.setError(error.error as ServerError, this.signInForm); }
      )
  }

}








