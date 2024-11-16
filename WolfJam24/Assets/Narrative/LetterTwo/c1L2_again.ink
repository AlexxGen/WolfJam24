#listen_again = false
#listen_next = false
#deliver = false
#speaker: Caller One 
Hello? Oh, you wanted to hear my thoughts about the letter again?
Yeah, I'm a CS major, and so is my girlfriend. 
Her phone broke a bit ago, but it's all fixed now.
I was having some stupid registration issues that didn't let sign up for like any classes.
My girl and I had weekend plans to go to a totally rad party. That's about it.

#speaker: You 
Thanks for being willing to share again. Really appreciated, buddy.
    * [Deliver] -> deliver
    * [Listen to next caller again] -> next

== next ==
#listen_next = true
    -> END
    
== deliver ==
#deliver = true
    -> END
