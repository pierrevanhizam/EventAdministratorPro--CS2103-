EventManagerPro
-------
### HELLO

Hey guys,

This is what I came up with. Didn't use any framework though. The UI is super crude I know but I couldn't write my add event / log-in function without a UI. Right now I store everything in a text file for the sake of simplicity. And I'm sure Melvin would use his magic and design great UI as usual:)

You need to put users.txt and events.txt in the debug folder for this to work.

How the log-in works currently:
Check username/password against a text file. If successfully logged-in, the instance of the user would be created and it would be passed from view to view (when new window open, the instance of the user will be passed). Not sure if there's a better way to do this.

Right now there are 3 classes (excluding View classes eg MainWindow)
- Student
- Event
- Venue


@Melvin
I realised that creating a UI and doing the binding thing is quite hard lol lots of respect for you! and please just overwrite the current UI with yours. it looks so bad right now-.- and i think using Page would be better than Window? Every time I change to another window, always can see the not-smooth transition. 


@Felix:
You probably already know this but these are the functions that require db connection that I could think of right now.
- get all events
- get all events that belong to the user
- save event details to database
- delete events
- search user (for log-in)
- get user

@Hizam
Not sure if the attribute for my classes are the same as yours. If there's anything you disagree with just edit k? Thanks!:)