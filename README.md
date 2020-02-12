# Doctors-Scheduling-Problem
- Making schedule for week for doctors working in three shifts
- Problem is solved using genetic algorithm
- GeneticSharp open-source library is used

## Chromosome representation
![chromosome](https://user-images.githubusercontent.com/37186937/74371630-6a025080-4dd9-11ea-87e3-2935afa050a9.PNG) 
- Doctors are represented by their IDs

## Constraints
- Doctor can work in one shift per day
- After working in third shift one day, doctor doesn't work in first or second shift next day
- Doctor doesn't work more than two successive first shifts
- Doctor doesn't work more than two successive second shifts
- Doctor doesn't work more than two successive third shifts
- Doctor doesn't have more than two successive days off
- After two successive third shifts, doctor has day off
- Constraints that include which doctor doesn't want to work with which doctors


### Fitness
Fitness is calculated as the number of violated constraints. The lower the fitness, the better the chromosome.

Various methods of selection, recombination and mutation can be chosen. Mutation probability value can be changed, recombination probability is 0.75.
