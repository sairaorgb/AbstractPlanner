# AbstractPlanner

Abstract planner is a design pattern that provides an interface for creating families of related or dependent objects.   
Four things are crucial in abstract design pattern. They are concrete product, concrete factory, abstract product, abstract factory  
abstract factories gives an interface for generating entities that are related to a family but in a way the client who asks for it need not worry about the group.  
concrete factories are the ones that are in charge of deleivering each product related to that group  
abstract product gives an interface that all products of a group must follow in an abstact way  
concrete product is the actual instance of object that will be created by concrete factory specific to factory's product family.  

This Github repo contains a console application in which abstract factory design principle is implemented. user is prompted for the day of the week and the course name and timings of the class are displayed. Here in this example, Three days of a week are considered a group and remaining two days of college another group. Each group reflects a concrete factory which itself are intitated inside abstract factory. name of the course and timings of this course are the concurrent products which are initiated as an abstract product specific to the user's input .Here the client(user) need to know which group of classes he/she have on that specified day which will be taken care of abstract factory.



![Logo](./structure.png)

credits : https://refactoring.guru/design-patterns/abstract-factory
