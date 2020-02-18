# RecycleAppPool
IIS 6 Recycle app pool from command line

This is a very simple command line application to recycle a given app pool from the command line.

The app pool name must be of the form

IIS://\<serverName\>/W3SVC.AppPools/\<AppPoolName\>

When using this you should remember that an app pool can apply to more than one application.

This has only been tested on IIS 6
