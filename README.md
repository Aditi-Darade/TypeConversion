You have the following values to convert:

byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
int b = 10; //Convert this value into "short" type (assign into another short type of variable)
string c = "10.34"; //Convert this value into "double" type using Parse  //Also, convert the same value into "decimal" type  using TryParse
decimal d = 20.3; //Convert this value into "string" type (assign into another string type of variable)
And then print all the converted values i.e 10, 10, 10.34, 10.34, 11.56.



You need to consider this order of concepts to prefer for conversion, where the "1" will be the highest priority and the "4" will be the least priority.

1. Implicit Casting

2. Explicit Casting

3. Parse or TryParse (as suggested above)

4. Conversion Methods