# Design-Patterns-Exercise
Exercise about use of design patterns. Pictures factory. Using my own idea agreed with SOLID. Well, maybe it is not really single responsible for all classes, but You get my point.
The task is to simulate multistage picture production process.
# Picture contains
1. Shape of picture frame.
2. Color of picture.
3. Text placed on picture.
4. Name of operation to apply to the text before printing it.
# Properties of creation:
1. Left Frame.
2. Right Frame.
3. Color.
4. Text.
# Detailed information
1. Left and Right frames are defined like: circle - '(' and ')', square '[' and ']', triangle '<' and '>'. There is an option to add another classes with different frames.
2. Thickness defines how many times the symbol of frame is repeated.
3. Color is just a text symbolising the color.
4. Text is any text.

For example:

(red) HelloWorld (red)
[[[]]] H e l l o W o r l d [[[]]]
<<green>> HelloWorld <<green>>

# Rules and restrictions
1. Order of creation is like: color, text, framing.
2. If the color is not specified, the color is blank.
3. If there is no matching operation, the text remains unchanged.
4. Picture can't be framed if text or color are nulls.
5. If there is no matching shape it displays error message.
6. Order has to validated during making process.
7. Calling Print() method is mandatory.
# Initial data
1. Has red, green and blue colors.
2. Three shapes: circle, square, triangle.
3. Operation on text: spacing, uppercase.
4. If picture has no color, thickness is set to 2.
5. After spacing thickness is 2.
6. If 4 and 5 occurs thickness is 3.
7. In other cases thickness is 1.

Concept of solution let user to add any color, frame shape or operation.
