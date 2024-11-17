#listen_again: false 
#deliver: false
#caller: 11
#speaker: You
Good morning, listeners! I hope today a litte bit more joy comes your way. 
The truck's still pretty full up on packages, so I have another letter here for y'all.
So, uh, it reads, hm, this one is a bit heavy.
A letter to mom. The sender asks about, I think, their siblings and how things are going.
Through gritted teeth, they share as little about their own hardships as possible.
With a promise of sending money, some good news, and hope for better, the letter ends.
Wow, just wow...
The grit and determination in these words, how I would love to meet someone with such spirit.
Any listeners out there, is this letter yours?
    -> first_caller
    
== first_caller ==
#speaker: Caller One
Hello, sir. I believe that letter is mine. 
I know there is no chance of it reaching it's destination now, but I was hoping I could get it back.
    #speaker: You
    * [May I get a name?] -> name
    * [Can I ask about the news you shared?] -> news
    
== name ==
#speaker: Caller One
Ah, yes, my name is Flore. My siblings are Amerie and Teddy.
    #speaker: You 
    * [Can I ask about the news you shared?] -> news
    * [Congragulations] -> congrats

== news ==
#speaker: Caller One 
Yes, I was just telling my mom that I got into school, finally. She worked for us, always.
I always wanted to pay her back, let her know all that work meant something.
    #speaker: You 
    * [Congrats on getting into school] -> congrats
    * [I'm sure she's proud of you] -> pride

== congrats ==
#speaker: Caller One
Thank you so much, I didn't think there was...
That there was still a chance to hear that.
#speaker: You 
You've done wonderfully for yourself. I'm coming to get this letter to you.
#speaker: Caller One
Ah, thank you, thank you so much. 
Thank you for giving me the opportunity to have this letter back,
and to know I did not send an inkling of hope before a great catastrophe. 
My heart can rest easier now.
    #speaker: You 
    * [Hear more] -> listen_again
    * [Deliver] -> deliver
    
== pride ==
#speaker: Caller One
I'm glad you think so. Though, I am happy this letter was not sent.
It lets my heart rest easier knowing I did not give her any hope before such disaster.
#speaker: You 
We can all use some hope, regardless of whats to follow after.
I'm sure she thinks of you warmly, always.
I'll be getting this letter to you soon.
#speaker: Caller One 
Thank you, thank you so much, truly. You're creating miracles, even in these terrible times.
I live in Gaiyea.
    #speaker: You 
    * [Hear more] -> listen_again
    * [Deliver] -> deliver
    
== listen_again ==
#listen_again: true
#deliver: false
 -> END
 
== deliver ==
#deliver: true
#listen_again: true
-> END