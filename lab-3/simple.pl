travel(l, r).
travel(r, l). 
 
move([X, X, Коза, Капуста], волк, [Y, Y, Коза, Капуста]) :- travel(X,Y).
move([X, Волк, X, Капуста], коза, [Y, Волк, Y, Капуста]) :- travel(X,Y).
move([X, Волк, Коза, X], капуста, [Y, Волк, Коза, Y]) :- travel(X,Y).
move([X, Волк, Коза, Капуста], ничего, [Y, Волк, Коза, Капуста]) :- travel(X,Y).
 
safe([X, _, X, _]).
safe([X, X, _, X]).

not_member(_, []) :- !.
not_member(X, [Head | Tail]) :-
  X \= Head,
  not_member(X, Tail).

solve([State | _], State, []).
solve([State | OtherStates], FinalState, [Move | OtherMoves]) :- 
  move(State, Move, NextState),
  safe(NextState),
  not_member(NextState, [State | OtherStates]),
  solve([NextState, State | OtherStates], FinalState, OtherMoves).


task(StartState, FinalState, Moves) :-
  solve([StartState], FinalState, Moves).