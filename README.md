# Signalr Web  Camp Demo
This is now demo walk through for the SignalR Chat Demo I complete at UK webcamps: http://thebeebs.co.uk/webcamp


1.	Create Empty MCV Site
2.	Add | SignalR Hub Class (v2) > ChatHub
3.	In Solution Explorer, expand the Scripts node. Script libraries for jQuery and SignalR are visible in the project.
4.	Open Chat hub. Change the namespace to SignalRChat
5.	Highlight hello void and paste snippet: demosignalrchathub
6.	Add OWIN startup class. Call it StartUp
7.	In the configuration void type app.MapSignalR();
8.	Create index.html add SNIPPET: demosignalrhtml
9.	Copy JS into file from snippet folder.
10.	Add bootstrap via nugget
11.	Publish to Azure
