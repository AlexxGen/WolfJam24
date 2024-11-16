#listen_again: false
#listen_next: false
#deliver: false
#caller: 33
#speaker: Caller Three
...
...Dad?
#speaker: You
Um, sorry, who is this? I'm not being pranked, right/
#speaker: Caller Three
No, no, it's me. It's Autumn.
#speaker: You
Autumn? My daughter? 
Why would she be calling...
#speaker: Autumn
That letter, it's mine. The invitation, it's for you.
#speaker: You 
What? Um, I'm finding this a bit hard to believe, sorry...
    * [Could you tell me some details?] -> details
    * [Why are you calling now?] -> calling
    
== details ==
#speaker: Autumn
The dress code, sage and peach. Peach is still your favorite color, right?
We're were holding it at the Union, nearby that park you always took me, too.
#speaker: You 
You're right, yeah, those details all match. I, uh...
    * [Can't believe it] -> believe
    * [Missed you so much] -> missed

== calling ==
#speaker: Autumn
Sorry, dad, I'm sorry I left like that. I just,
I wasn't sure if you could accept it.
But now that the world's gone to shit, I see how stupid it is.
    -> confession
    
== confession ==
#speaker: You 
What are you talking about?
#speaker: Autumn
The wedding invite, I'm sure the names are smudged if you're asking that.
I, I'm, or I was getting married to a girl.
#speaker: You 
Oh, sweetheart...
    * [Congrats] -> congrats
    * [I could never be mad] -> mad
    -> END
    
== believe ==
#speaker: Autumn
I don't blame you, it's been years.
I'm sorry, this is all my fault. If I just didn't run away...
#speaker: You 
No, don't blame yourself, dear. 
I've spent all this time thinking it was my fault, but those kinda thoughts do no one any good.
#speaker: Autumn
Dad, you haven't done anything wrong. You've always supported me.
I shouldn't have thought this time would be any different.
    -> confession
    
== missed ==
#speaker: Autumn
I missed you, too, dad, so much. That's why I sent that invite.
I was getting married, to a girl. Her name is Laila, and she's with me.
All those years ago, I got scared, but not anymore.
I love you, dad.
#speaker: You 
I love you too, Autumn
    -> wrap
    
== congrats ==
#speaker: Autumn
Thanks, dad. I've always wanted to hear that.
#speaker: Dad
You didn't need to wait. I would've told you whenever.
#speaker: Autumn
I know, I'm sorry. I-
#speaker: You 
It's okay, you don't have to say anything.
    -> wrap
    
== mad ==
#speaker: Autumn
You've never been mad at me for anything. I don't know why I was so silly.
#speaker: You 
It's okay, dear, fear is a hard force to fight. 
I was scared to be alone now that the world is pratically gone.
These letters, this radio, it's me holding on to what I can.
You have no clue how happy I am to hear your voice.
    -> wrap
    
== wrap ==
#speaker: You 
I'm heading your way. Stay there. Just tell me where you are.
#speaker: Autumn
Ritny, I'm in Ritny.
#speaker: You 
I can't wait to see you, and meet her, and I'll be there soon.
    * [Deliver] -> deliver
    * [Deliver] -> deliver
    
== deliver ==
#deliver: true
    -> END

