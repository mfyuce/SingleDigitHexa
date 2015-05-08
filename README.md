# SingleDigitHexa
A simple library/C# file to display/store hexadecimal notations with single digits for space considerations.

Mostly you will design better not to use this code, but in any case, if you need to store hexadecimal notations to a database or some other medium as text, this code may be of use to you.

It will take only two bytes (unicode) to store a single byte hexadecimal representation. Otherwise, a single byte hexadecimal, like 0xFF, will take four bytes only two be stored as string.

This code assumes that, medium to store the value is unicode enabled.


