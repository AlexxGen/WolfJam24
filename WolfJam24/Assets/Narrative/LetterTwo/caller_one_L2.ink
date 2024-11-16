#listen_again: false
#deliver: false
#listen_next: false
#caller: 12
#speaker: You
Alrighty, time for our next letter.
This is such a jolly and cute one, a rare find these days.
The sender of this letter is a college-aged student with a partner whose phone broken recently.
They seem to be sending letters back and forth to each other, like pen pals. 
The sender complains of issues with class registration and an exciting event that was happening the weekend following the send date.
Truly adorable. Is this any listener's lost love letter?
    -> caller_one
    
== caller_one ==
#speaker: Caller One 
Hello? I think that letter might be mine. My girlfriend just got her phone fixed before...everything.
    #speaker: You 
    * [Does she go to the same school?] -> same
    * [What's your major?] -> major
    
== same ==
#speaker: Caller One 
Yup! We're actually the same major and everything. 
I was super excited when we got the acceptance letters.
    #speaker: You
    How lovely.
    * [What are your majors?] -> major
    * [What issue did you have with registration?] -> issue

== major ==
#speaker: Caller One 
Computer science. Me and my girl are both kinda tech bros.
Well, not hardware clearly. Otherwise, her phone woulda been fixed by now.
    #speaker: You
    * [What was that issue with class?] -> issue
    * [What were you going to do next weekend?] -> weekend
    
== issue ==
#speaker: Caller One 
I wasn't getting the classes I needed. Stupid issues that shouldn't have happened. 
Couldn't barely anything on my schedule.
    #speaker: You 
    That's rough, buddy.
    * [Wrap up call] -> wrap
    * [Do you remember your weekend plans?] -> weekend
    
== weekend ==
#speaker: Caller One 
Uhhh, I think it was some party. It was gonna be totall rad and super fun.
I couldn't wait to bring her to something like that.
    #speaker: You
    Sounds like a blast.
    ->wrap
    
== wrap ==
#speaker: You 
Thanks for sharing your story with me. There's another caller on deck for this letter, but it might be yours.
Let's see what happens. I might be heading your way.
#speaker: Caller One 
Sure, I live.
    #speaker: You 
    * [Next caller] -> next
    * [Deliver] -> deliver
    
== next ==
#listen_next: true
    -> END
    
== deliver ==
#deliver: true
    -> END