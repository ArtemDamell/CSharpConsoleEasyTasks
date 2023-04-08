# CSharpConsoleEasyTasks
## Several easy console tasks created by me in 2020.


# Game Task

In their free time, classmates Vasya and Petya like to play various logic games: battleship, tic-tac-toe, chess, checkers, and much more. The guys have already tried and played all sorts of classic games of this kind, including computer ones. One day, they wanted to play something new, but they couldn't find anything suitable.

Then Petya came up with the following game "Guessing Game": Two participants play. The first one thinks of any three-digit number, such that the first and last digits differ from each other by more than one. Then the player who thought of the number flips the number, swapping the first and last digits, thus obtaining another number. Then the maximum of the two obtained numbers is subtracted from the minimum. The task of the second player is to guess the number itself based on the first digit of the resulting difference.

For example, if Vasya thought of the number 487, then by swapping the first and last digits, he will get the number 784. Then he will have to subtract 487 from 784, as a result of which the number 297 will be obtained, which Petya must guess based on the specified first digit "2" taken from this number. Petya is better at math than Vasya, so he almost always wins in games of this type. But in this case, Petya cheated and deliberately came up with a game in which he will not lose to Vasya in any case. The thing is that the game invented by Petya has a winning strategy, which consists of the following: the desired number is always a three-digit number, and its second digit is always nine, and to get the value of the last digit, it is enough to subtract the first digit from nine, i.e., in the above example, the last digit is 9-2=7. Help Petya simplify the process of guessing the number based on its first digit by writing a corresponding program.

# Sum Task

In this problem, you can use the formula for the arithmetic progression: Sn = (a1+an)*n/2. But novice programmers often forget this formula and in this case resort to computing this sum using a loop and solve this problem using the following algorithm:

read(n);
s=0;
for i=1..n{ s=s+i; }
write(s);

But the complexity of this problem is not in computing this sum and the above algorithm fails the test! It turns out that you need to read the problem statement very carefully, especially the constraints on the number N. The thing is that this number can be negative!!!
