import { NgModule } from '@angular/core';
import { PrivateContentLayoutComponent } from './layouts/private-content/private-content-layout.component';
import { PrivateFullLayoutComponent } from './layouts/private-full/private-full-layout.component';
import { SharedModule } from '../shared/shared.module';
import { PrivateHomeComponent } from 'app/private/pages/private-home/private-home.component';
import { FeedsService } from 'app/shared/services/feeds/feeds.service';
import { PrivateProfileComponent } from './pages/private-profile/private-profile.component';
import { PrivateNavbarComponent } from './components/shared/private-navbar/private-navbar.component';
// tslint:disable-next-line: max-line-length
import { PrivateNotificationSidebarComponent } from './components/shared/private-notification-sidebar/private-notification-sidebar.component';
import { PrivateSidebarComponent } from './components/shared/private-sidebar/private-sidebar.component';
import { PrivateProfileHeadComponent } from './components/profile/private-profile-head/private-profile-head.component';
import { PrivateProfileIntroComponent } from './components/profile/private-profile-intro/private-profile-intro.component';
import { PrivateProfileProjectsComponent } from './components/profile/private-profile-projects/private-profile-projects.component';
import { PrivateProfileCommunitiesComponent } from './components/profile/private-profile-communities/private-profile-communities.component';
import { PrivateProblemCardComponent } from './components/problem/private-problem-card/private-problem-card.component';
import { PrivateCommunityFeedsComponent } from './components/communities/private-community-feeds/private-community-feeds.component';
import { PrivateCommunityCardComponent } from './components/communities/private-community-card/private-community-card.component';
import { PrivateProblemFeedsComponent } from './components/problem/private-problem-feeds/private-problem-feeds.component';
import { PrivateProjectFeedsComponent } from './components/project/private-project-feeds/private-project-feeds.component';
import { PrivateProjectCardComponent } from './components/project/private-project-card/private-project-card.component';
import { PrivateHomeTopnavbarComponent } from './components/shared/private-navbar/private-home-topnavbar/private-home-topnavbar.component';
import { PrivateChatMessageComponent } from './components/shared/chat/private-chat-message/private-chat-message.component';
import { PrivateChatFeedsComponent } from './components/shared/chat/private-chat-feeds/private-chat-feeds.component';
import { PrivateAddProblemComponent } from './components/shared/modals/problem/private-add-problem/private-add-problem.component';
import { PrivateIdeaCardComponent } from './components/idea/private-idea-card/private-idea-card.component';
import { PrivateIdeaFeedsComponent } from './components/idea/private-idea-feeds/private-idea-feeds.component';
import { PrivatePostsComponent } from './pages/home/private-posts/private-posts.component';

@NgModule({
    declarations: [
        PrivateContentLayoutComponent,
        PrivateFullLayoutComponent,
        PrivateHomeComponent,
        PrivateProfileComponent,
        PrivateNavbarComponent,
        PrivateNotificationSidebarComponent,
        PrivateSidebarComponent,
        PrivateProfileHeadComponent,
        PrivateProfileIntroComponent,
        PrivateProfileProjectsComponent,
        PrivateProfileCommunitiesComponent,
        PrivateProblemCardComponent,
        PrivateCommunityFeedsComponent,
        PrivateCommunityCardComponent,
        PrivateProblemFeedsComponent,
        PrivateProjectFeedsComponent,
        PrivateProjectCardComponent,
        PrivateHomeTopnavbarComponent,
        PrivateChatMessageComponent,
        PrivateChatFeedsComponent,
        PrivateAddProblemComponent,
        PrivateIdeaCardComponent,
        PrivateIdeaFeedsComponent,
        PrivatePostsComponent,
    ],
    entryComponents: [
        PrivateAddProblemComponent,
    ],
    imports: [
        SharedModule
    ],
    exports: [
        SharedModule,
        PrivateContentLayoutComponent,
        PrivateFullLayoutComponent,
        PrivateHomeComponent,
        PrivateProfileComponent,
        PrivateNavbarComponent,
        PrivateNotificationSidebarComponent,
        PrivateSidebarComponent,
        PrivateProfileHeadComponent,
        PrivateProblemCardComponent,
        PrivateCommunityFeedsComponent,
        PrivateCommunityCardComponent,
        PrivateProblemFeedsComponent,
        PrivateProjectFeedsComponent,
        PrivateProjectCardComponent,
        PrivateHomeTopnavbarComponent,
        PrivateChatMessageComponent,
        PrivateChatFeedsComponent,
        PrivateAddProblemComponent,
        PrivateIdeaCardComponent,
        PrivateIdeaFeedsComponent,
        PrivatePostsComponent,
    ],
    providers: [
        FeedsService
    ]
})

export class PrivateSharedModule { }
