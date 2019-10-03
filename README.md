# PlatformerExample
Given a platform with positions we make left or right jumps, after a jump the previous position is no longer available.


Example output
```
Platform size: 6
Current position: 3

  Current list:
  1 2 3 4 5 6
Did a left jump!
Removed: 3
Current position: 1

  Current list:
  1 2 4 5 6
Did a right jump!
Removed: 1
Current position: 4

  Current list:
  2 4 5 6
Did a right jump!
Removed: 4
Current position: 6

  Current list:
  2 5 6
Can not do right jump!
Current position: 6

  Current list:
  2 5 6
Did a left jump!
Removed: 6
Current position: 2

  Current list:
  2 5
Can not do left jump!
Current position: 2

  Current list:
  2 5

```
