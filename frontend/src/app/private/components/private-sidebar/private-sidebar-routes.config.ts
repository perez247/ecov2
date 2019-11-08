import { RouteInfo } from './private-sidebar.metadata';
import { AppRoutes } from 'app/shared/routes/app.routes';

let appRoutes = AppRoutes.generateRoutes();


export const ROUTES: RouteInfo[] = [

    {
        path: appRoutes.private.profile.path, title: 'About Me', icon: 'icon-emoticon-smile', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: []
    },
    {
        path: appRoutes.private.home.path, title: 'Home', icon: 'ft-home', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: []
    },
    // {
    //     path: '', title: 'Menu Levels', icon: 'ft-align-left', class: 'has-sub', badge: '1', badgeClass: 'badge badge-pill badge-danger float-right mr-1 mt-1', isExternalLink: false,
    //     submenu: [
    //         { path: 'javascript:;', title: 'Second Level', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: true, submenu: [] },
    //         {
    //             path: '', title: 'Second Level Child', icon: '', class: 'has-sub', badge: '', badgeClass: '', isExternalLink: false,
    //             submenu: [
    //                 { path: 'javascript:;', title: 'Third Level 1.1', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: true, submenu: [] },
    //                 { path: 'javascript:;', title: 'Third Level 1.2', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: true, submenu: [] },
    //             ]
    //         },
    //     ]
    // },
    {
        path: '/changelog', title: 'Map', icon: 'ft-map', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: []
    },
    // { path: 'https://pixinvent.com/apex-angular-4-bootstrap-admin-template/documentation', title: 'Documentation', icon: 'ft-folder', class: '', badge: '', badgeClass: '', isExternalLink: true, submenu: [] },
    // { path: 'https://pixinvent.ticksy.com/', title: 'Support', icon: 'ft-life-buoy', class: '', badge: '', badgeClass: '', isExternalLink: true, submenu: [] },

];

// export class SideBar {
//     static getMenu(paths: any) {
//         return [
//             {
//                 path: paths.private.profile.path, 
//                 title: 'About Me', 
//                 icon: 'icon-emoticon-smile', 
//                 class: '', badge: '', 
//                 badgeClass: '', 
//                 isExternalLink: false, 
//                 submenu: []
//             },
//             {
//                 path: paths.private.home.path, 
//                 title: 'Home', icon: 'ft-home', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: []
//             },
//             {
//                 path: '/changelog', title: 'Map', icon: 'ft-map', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: []
//             },
//         ] as RouteInfo[];
//     }
// }
