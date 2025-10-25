# API TODO w .NET (Visual Studio)

Proste **API TODO** zbudowane w oparciu o **.NET8 Web API**, umożliwiające tworzenie, pobieranie, aktualizowanie i usuwanie zadań danego dnia. 

## Elementy do rozwoju projektu:
 - Rejestracja i logowanie użytkowników
 - Autoryzacja użytkownika na za pomocą JWT Token
 - Paginacja rekordów
 - Udostępnianie zadań innym użytkownikom

## Uruchomienie projektu lokalnie

1. Sklonuj repozytorium:
   git clone https://github.com/RadoslawBarczynski/Todo
2. Otwórz solucje projektu oraz wejdź:
 Tools → NuGet Package Manager → Manage NuGet Packages for Solution → Restore
3. Utworzyc appsettings.json z connection stringiem do bazy:
```
{
  "ConnectionStrings": {
    "TodoDatabase": "[Baza danych]"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```
5. Wybierz projekt startowy

## Dostępne endpointy
| Metoda      | Endpoint               | Opis                              |
| ----------- | -----------------------| ----------------------------------|
| GetTodos    | `/api/Todo/GetTodos`   | Pobranie wszystkich zadań dnia    |
| CheckTodo   | `/api/Todo/CheckTodo`  | Zaznaczenie zadania               |
| AddTodo     | `/api/Todo/AddTodo`    | Dodanie nowego zadania            |
| UpdateTodo  | `/api/Todo/UpdateTodo` | Aktualizacja istniejącego zadania |
| DeleteTodo  | `/api/Todo/DeleteTodo` | Usunięcie zadania                 |


