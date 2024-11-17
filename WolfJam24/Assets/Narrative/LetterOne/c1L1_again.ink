#deliver: false
#listen_again: false
#caller: 11
#speaker: Caller One 
Hello? Ah, you wanted to hear my story again? Sure thing.
My name is Flore. The letter you found, I was sending it to my mother.
I wanted to know about my siblings, Amerie and Teddy, make sure they're okay, you know?
I also wanted to tell her I finally got into school like she always hoped for me to do.
It's been hard here, new country, no family, but I think I made her proud. I didn't waste her effort. 
I hope you can believe me and bring my letter back. I live in Gaiyea.
    #speaker: You 
    * [Listen Again] -> listen_again
    * [Deliver] -> deliver
    
== listen_again ==
#listen_again: true
#deliver: false
    -> END
== deliver ==
#listen_again: false
#deliver: true
    -> END
