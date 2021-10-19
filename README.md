# Open closed principle

## What is the open closed principle?

[Brief introduction](https://medium.com/@a.vathanaka/benefits-of-the-open-closed-principle-dc9284d47598)

[Learn about the open closed principle](https://medium.com/@alexandre.malavasi/why-is-the-open-closed-principle-so-important-bed2f2a0d4c7)

Understand the complexities of the first code example having to have 3 different methods to generate account types and the switch statement inside the generate method which would need to happen every time the customer object is instantiated. 

Then how much simpler, cleaner and more manageable is it to create derived types from a super/base class.

## Practical 

You work abroad as a greeter for a nightclub which is miles more interesting than writing code. The problem is you need to be able to greet in multiple languages. This application has been written by a new developer who has not had your extensive training in the solid principles. 

The naughty developer broke the open closed principle by adding a switch statement to the Greet method. This means that any additional greetings will need adding to the greet method and the switch statement will become hard to manage.

Your task is to take this application and apply the open closed principle to it.

1.) Extract an interface IGreeter.cs to use as a base class  
2.) Create derived classes which are language specific  
3.) Update the tests to use the corresponding derived class

## Evidence for the matrix

Create a file called open-closed.md

Answer the following questions:

What is the open closed principle?   
Why do we use it?   

Insert a link that goes to that file in the repo in your GitHub account.

We will use this as evidence for the O of the SOLID principles.

