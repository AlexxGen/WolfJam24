#listen_again: false
#listen_next: false
#deliver: false
#caller: 13
#speaker: You
Next letter, this one is a bit water damaged. The text is quite a bit smuged, but let's see what I can make out.
Okay, this seems to be a wedding invitation. Really not a lot of details to go off of.
Who's our lucky listener out there who is soon to be married?

#speaker: Caller One 
Hello, good fellow truck driver! I was soon to be married this coming change of season.
    #speaker: You
    Congrats! Happy to hear it.
    * [What is the dress code?] -> dress
    * [Where are you having your wedding?] -> location
    
== dress ==
#speaker: Caller One 
Lavender and sage. We've always loved light, airy, nature-y colors.
My partner also just wanted to go with something less frequently done.
Be special and unique, you know?
    #speaker: You 
    A beautiful combination, indeed.
    * [Where are you having your wedding?] -> location
    * [Wrap up] -> wrap

== location ==
#speaker: Caller One 
We're having it in this venue by the harbor. 
Our color scheme may not match the beach, but we love the seaside view.
It's still indoors, but you get to see the gorgeous ocean.
    #speaker: You 
    I do love the seaside.
    * [What's the food gonna be like?] -> food
    * [Wrap up] -> wrap
    
== food ==
#speaker: Caller One 
Oh, it's a short wedding. We know most of our guests can't stay long. 
It's just in the morning, so no food served.
    #speaker: You 
    * [What will the dress code be?] -> dress
    * [Wrap up] -> wrap
    
== wrap ==
#speaker: You 
It's great to hear about a joyous occasion admist these dreary days. 
Even without a ceremony, I hope your relationship is going strong.
    * [Next caller] -> next
    * [Deliver] -> deliver
    -> END
    
== deliver ==
#deliver: true
    -> END
    
== next ==
#listen_next: true
-> END