#listen_again: false
#listen_next: false
#deliver: false
#caller: 22
#speaker: Caller Two
Hi, I uh think my boyfriend actually sent that letter. Or, well, was trying to send that to me.
    #speaker: You
    * [Could you tell me more about him?] -> elaborate
    * [What makes you think so?] -> reasoning

== elaborate ==
#speaker: Caller Two
Yeah, sure. He goes to a different college from me, a bit up North. 
So, no phone means no contact, but there's no way he would let that happen. 
He's a physic and math major, so he loves to tinker.
Is there something specific you wanted to know?
    #speaker: You 
    * [Did he say anything about a certain weekend?] -> weekend
    * [Why are you calling about the letter?] -> reason

== reasoning ==
#speaker: Caller Two
I broke my phone a bit ago, few weeks maybe. My boyfriend and I are long distance, so our alternative was letters.
I never got his response, so I was hoping this letter was it. 
He's a goofy guy, I bet he called the letters medival or something stupid.
    #speaker: You 
    Yeah, actually, he sure did.
    * [What major is he?] -> major
    * [Did he end up driving down?] -> drive

== major ==
#speaker: Caller Two
A physics major! Soon to be math major, too. Silly, since he dropped computer science to do math.
I know he was worried about registrations since everything's happening in a bit of an odd order and quite close together.
    #speaker: You 
    * [Do you know about a special weekend?] -> weekend
    * [Wrap up] -> wrap
    
== drive ==
#speaker: Caller Two
Oh, uh...
No, he, didn't manage to make it down here. There was...
There was an accident, that's actually why I was really, really hoping that this letter was his.
Just something, one more thing of his, you know?
#speaker: You 
Oh, dear, I'm so sorry to hear that. My condolences for your loss.
#speaker: Caller Two
Ah, thank you. A lot has happened recently, to everyone, you know? 
#speaker: You 
Sure has. I hope something to brighten your day happens soon.
    -> wrap
    
== weekend ==
#speaker: Caller Two
Special weekend? Not sure, we drive back and forth to each other a lot.
I think maybe...he said something about a friend, Alex, but I can't remember what.
    #speaker: You 
    * [Did he drive up to you recently?] -> drive
    * [Wrap up] -> wrap
    
== reason ==
I um, he can't call himself. He, uh, there was an accident on his drive down. 
That's actually why I was really, really hoping that this letter was his.
Just something, one more thing of his, you know?
#speaker: You 
Oh, dear, I'm so sorry to hear that. My condolences for your loss.
#speaker: Caller Two
Ah, thank you. A lot has happened recently, to everyone, you know? 
#speaker: You 
Sure has. I hope something to brighten your day happens soon.
    -> wrap

== wrap ==
#speaker: You 
Truly, thank you so much for sharing your story. I hope I can do something to help you reconnect with what you've lost.
    * [Listen again] -> again
    * [Deliver] -> deliver
    
== again ==
#prev_caller: 22
#listen_again: true
    -> END
    
== deliver ==
#deliver: true
    -> END