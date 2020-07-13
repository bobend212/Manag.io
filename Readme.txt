Funkcjonalnosci (priorytetowo):

--KONTA UZYTKOWNIKOW--

Rejestrowanie(dodawanie) uzytkownikow do bazy [MANAGER, LEADER]
Usuwanie uzytkownikow z systemu
Edycja kont uzytkownikow w systemie
Mozliwosc logowania [ALL]
Mozliwosc wylogowywania
Edycja swojego konta [ALL]
Role
Przypisywanie rol, usuwanie, zmienianie.

--PROJEKTY/KLIENCI--

Lista projektow/klientow [ZALOGOWANI ALL]
Mozliwosc edycji, usuwania i dodawania projektu do bazy

--WORKFLOW--

Project Workflow [Zalogowani ALL] (Kto na jakim projekcie w danej chwili sie znajduje)
Przypisywanie uzytkownikow do projektu [MANAGER, LEADER] drag and drop?
Ustawianie stanu w jakim znajduje sie dany projekt // not ready, in progress, ready, done, on hold (dopracowac)

--TIMESHEET--

Stowrzenie miesiaca dla nowego timesheeta, nastepnie praca na tym miesiacu.
Wyslanie timesheeta do zatwierdzenia?? (raczej powinno byc takie cos)

Dodawanie do bazy swojego czasu pracy. (Timesheet) [USERS ALL] // DATE, TYPE, PROJECT, TIME(h)
CRUD na Timesheecie


--OTHER--

Mozliwosc generowania raportu do PDF/Excel/csv

<<---- ENDPOINTS ---->>

*PROJECT*
http://localhost:5000/projects  = GET ALL PROJECTS
http://localhost:5000/projects/{projectId} = GET PROJECT DETAILS
http://localhost:5000/projects/{projectId} = DELETE PROJECT
http://localhost:5000/projects/{projectId} = EDIT PROJECT

*TIMESHEET*
-Id
-UserId
-Month
-Year

http://localhost:5000/timesheets = get all timesheeets
http://localhost:5000/timesheets/{timesheetId} = timesheet details with records
http://localhost:5000/timesheets/{timesheetId} = delete details with records
http://localhost:5000/timesheets/{timesheetId} = edit details with records


--> /// Testy Jednostkowe /// <--
--> /// Stworzyc koncepcje UI /// <--
--> /// Opracowac DB Schema! /// <--
