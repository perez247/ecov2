import { RouteInfo } from './private-sidebar.metadata';
import { AppRoutes } from 'app/shared/routes/app.routes';

const appRoutes = AppRoutes.generateRoutes();


export const ROUTES: RouteInfo[] = [

    {
        path: '',
        title: 'About Me',
        icon: 'icon-emoticon-smile',
        class: 'has-sub',
        badge: '',
        badgeClass: '',
        isExternalLink: false,
        submenu: [
            {
                path: appRoutes.private.profile.path,
                title: 'My profile',
                icon: 'ft-user',
                class: '',
                badge: '',
                badgeClass: '',
                isExternalLink: true,
                submenu: []
            },
            {
                path: appRoutes.logout,
                title: 'Logout',
                icon: 'ft-log-out',
                class: '',
                badge: '',
                badgeClass: '',
                isExternalLink: true,
                submenu: []
            }
        ]
    },
    {
        path: appRoutes.private.home.path,
        title: 'Home',
        icon: 'ft-home',
        class: '',
        badge: '',
        badgeClass: '',
        isExternalLink: false,
         submenu: []
    },
    {
        path: '/changelog',
        title: 'Map',
        icon: 'ft-map',
        class: '',
        badge: '',
        badgeClass: '',
        isExternalLink: false,
        submenu: []
    },
];





    // {
    //     path: '',
    //     title: 'Menu Levels',
    //     icon: 'ft-align-left',
    //     class: 'has-sub', badge: '1', badgeClass: 'badge badge-pill badge-danger float-right mr-1 mt-1', isExternalLink: false,
    //     submenu: [
    //         {
    //              path: 'javascript:;',
    //              title: 'Second Level', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: true, submenu: [] },
    //         {
    //             path: '', title: 'Second Level Child', icon: '', class: 'has-sub', badge: '', badgeClass: '', isExternalLink: false,
    //             submenu: [
    //                 {
    //                      path: 'javascript:;',
    //                      title: 'Third Level 1.1', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: true, submenu: [] },
    //                 {
    //                      path: 'javascript:;',
    //                      title: 'Third Level 1.2',
    //                      icon: '', class: '', badge: '', badgeClass: '', isExternalLink: true, submenu: [] },
    //             ]
    //         },
    //     ]
    // },

