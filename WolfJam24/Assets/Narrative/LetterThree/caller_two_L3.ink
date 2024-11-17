#listen_again: false
#listen_next: false
#deliver: false
#caller: 23
#speaker: Caller Two
Hiya! I think you might have my wedding invitation!
    #speaker: You 
    I sure might.
    * [What's the timeline of your wedding?] -> food
    * [Where are you having your wedding?] -> location
    
== dress ==
Formal attire in a winter color palette.
You know, burgundy, navy, those rich, dark colors.
There's no other colors to make someone look so expensive.
    #speaker: You 
    How luxurious.
    * [What are your guests eating?] -> food
    * [Wrap up] -> wrap

== location ==
#speaker: Caller Two
Capitol banquet hall. We've always loved the lavishness of it.
If we're going to make everyone spend all that money on coming to our wedding, we want them to feel its worth it.
Plus, on my special day, I want to feel truly special.
    #speaker: You 
    I'm sure it would've been gorgeous.
    * [What will your guests be wearing?] -> dress
    * [Wrap up] -> wrap
    
== food ==
#speaker: Caller Two
After the morning ceremony, we're having an evening reception.
We really just wanted to spend the whole day with our loved ones.
The joy of marriage...you just can't keep that to yourself.
    #speaker: You 
    I'm sure you're right. I haven't been to a wedding in so long.
    * [Where will your wedding be?] -> location
    * [Wrap up] -> wrap
    
== wrap ==
#speaker: You
What a decadent wedding you had planned. I'm sorry you lost the opportunity to have it.
I hope you're still trying to live it large, even if we have nothing. 
#speaker: Caller Two
I sure am. Swing by Oakley if that letter happens to be mine.
    #speaker: You
    * [Next caller] -> next
    * [Deliver] -> deliver
    
== deliver ==
#deliver: true
    -> END
    
== next ==
#listen_next: true
    -> END
