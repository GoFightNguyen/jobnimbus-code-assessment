# jobnimbus-code-assessment

Write a method that takes a string argument and returns whether or not characters in the string have matching brackets.
Meaning for every `<` there is a corresponding `>` bracket.
Return true if they do, return false if they do not.

Please unit test with the following use cases (and any others you choose to ensure functionality).
Potential Test strings and expected results:
- `<>` - True
- `><` - False (closed bracket can’t proceed all open brackets.)
- `<<>` - False (one bracket pair was not closed)
- `“”` - True. (no brackets in the string will return True)
- `<abc...xyz>` - True (non-bracket characters are ignored appropriately)

## Getting Started

A [development container](https://containers.dev/) is used to isolate the development environment.
It includes dotnet 8.

Whether or not you decide to develop in the devcontainer,
follow these steps:
1. `cd ./src`
2. `dotnet test`

## Thoughts

Since it was not explicit whether candidate strings could have characters outside of bracket pairs,
such as `a<>` or `<>b`,
I decided to allow it.

Since the instructions did not indicate the characters between the bracket pairs would be significant in the future,
such as the `a` in `<a>`,
I was not concerned about losing them.

I chose the approach of assigning a numerical value,
1 to `<` and -1 to `>`.
Therefore, each string had matching brackets only if
- at no point did the sum become negative
- the end sum was 0

Another approach is (_note: there is nuance here that I excluded such as for the `><` scenario_):
- find the outermost bracket pair
- remove it
- repeat until there are no more proper pairs
- return true if there are no more brackets, otherwise false

I did not try the latter approach because it seemed slightly more complex than the first once I became unconcerned about losing characters between the brackets.
Thinking about it now, it could be easier to comprehend as it might be a better conceptual mapping to how people think.
