
export class AppRoutes {

    static generateRoutes() {
        return {
                    // Routes for public pages
            public: {
                path: `public`,
                name: `public`,

                // Home page of public site
                signIn: {
                    name: 'signin',
                    path: `public/signin`
                },

                // Signup route
                signUp: {
                    name: 'signup',
                    path: `public/signup`
                },

                // Verify email route
                verifyEmail: {
                    name: 'verify-email',
                    path: `public/verify-email`
                },

                // forgot password route
                forgotPassword: {
                    name: 'forgot-password',
                    path: `public/forgot-password`
                },

                // reset password route
                resetPassword: {
                    name: 'reset-password',
                    path: `public/reset-password`
                },

                // Send email verification
                sendEmailVerification: {
                    name: 'send-email-verification',
                    path: `public/send-email-verification`
                }
            },

            // Routes for private pages
            private: {
                path: `private`,
                name: `private`,

                // Home
                home: {
                    name: `home`,
                    path: `private/home`,


                    // Feeds for:-
                    // Communities
                    communities: {
                        name: `communities`,
                        path: `private/home/communities`
                    },

                    // Projects
                    projects: {
                        name: `projects`,
                        path: `private/home/projects`
                    },

                    // Ideas
                    idea: {
                        name: `idea`,
                        path: `private/home/idea`
                    },

                    // Problems
                    problems: {
                        name: `problems`,
                        path: `private/home/problems`,
                    },

                    // posts
                    posts: {
                        name: `posts`,
                        default: `posts/user`,
                        withParams: `posts/:type`,
                        path: `private/home/posts`,

                        // feeds/posts from users
                        user: {
                            name: `user`,
                            path: `private/home/posts/user`
                        },

                        // feeds/posts from everywhere
                        global: {
                            name: `global`,
                            path: `private/home/posts/global`
                        }
                    },

                    // Map
                    map: {
                        name: `map`,
                        path: `private/home/path`
                    }

                },

                // User profile page
                profile: {
                    name: `profile`,
                    path: `private/profile`,


                    // Overview
                    intro: {
                        name: `intro`,
                        path: `private/profile/intro`
                    },

                    // projects
                    projects: {
                        name: `projects`,
                        path: `private/profile/projects`
                    },

                    // Communities
                    communities: {
                        name: `communities`,
                        path: `private/profile/communities`
                    }
                }

            },

            // Routes for admin pages
            admin: {
                path: `admin`,
                name: `admin`
            },

            logout: 'logout'
        }
    }

}
