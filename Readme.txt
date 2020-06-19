Funkcjonalnosci:
 1. Rejestrowanie(dodawanie) uzytkownikow do bazy [MANAGER, LEADER]
 1.2 Usuwanie uzytkownikow z systemu
 1.3 Edycja kont uzytkownikow w systemie

 2. Mozliwosc logowania [ALL]
 2.2 Mozliwosc wylogowywania

 3. Edycja swojego konta [ALL]

 4. Lista projektow/klientow [ZALOGOWANI ALL]

 5. Project Workflow [Zalogowani ALL] (Kto na jakim projekcie w danej chwili sie znajduje)
 5.1 Przypisywanie uzytkownikow do projektu [MANAGER, LEADER]
 5.2 Ustawianie stanu w jakim znajduje sie dany projekt // not ready, in progress, ready, done, on hold

 6. Dodawanie do bazy swojego czasu pracy przy danym projekcie. (Timesheet) [USERS ALL] // DATE, TYPE, PROJECT, TIME(h)

 7. Mozliwosc generowania raportu do PDF/Excel/csv

---- ENDPOINTS ----

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
