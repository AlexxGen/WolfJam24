#listen_again: false
#listen_next: false
#deliver: false
#caller: 22
#speaker: Caller Two
Oh, hi. Yeah, I can tell you about what happened again. 
I believe the letter you have is from my boyfriend. He passed recently in an accident.
We had been writing letters to each other because my phone broke, and I never got his last letter.
He's a college student studying physics and math. He was silly with a great sense of humor.
I hope this description matches this letter, I would love to have just, anything to remind me of him again.
If you could bring to Limeleaf, I'd be enternally grateful.
#speaker: You 
Thank you so much for being able to share that with me again. Thank you for your bravery, and being bold enough to reach out in these trying times.
    * [Listen Again] -> again
    * [Deliver] -> deliver

== again ==
#listen_again: true
#prev_caller: 22
    -> END
    
== deliver ==
#deliver: true
    -> END
