---
stack: C#
lang: all
---

## benchmarks Replace, changed strings
 Will a Replace call that makes no changes in the string return faster? This helps us design faster programs by giving us more information about how Replace works.
*Version 1* 
This version of the code calls Replace, but the arguments given will cause no change to occur.
*Version 2*
Here we replace a string that exists inside the input string—so a change does occur.
Result It is faster to call Replace() when the method does not make a change to the string data. This case is optimized.