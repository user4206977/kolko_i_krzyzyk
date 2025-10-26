# 🎮 Kółko i Krzyżyk (Tic Tac Toe)

Prosty projekt gry **Kółko i Krzyżyk** napisany w **C# (WPF)**.  
Gra jest przeznaczona dla dwóch graczy lokalnych i posiada licznik czasu, system punktacji oraz losowy wybór gracza rozpoczynającego.

---

## 🧩 Funkcje

- ✅ Rozgrywka dla dwóch graczy (X i O)
- 🕒 Licznik czasu gry (od momentu uruchomienia)
- 🔁 Przycisk **"Nowa gra"** umożliwiający szybki restart planszy
- 📜 Przycisk **"Zasady gry"** z opisem reguł
- 🧮 Licznik:
  - liczby wygranych X
  - liczby wygranych O
  - liczby remisów
- 🎲 Losowy wybór gracza, który zaczyna rundę
- 🪟 Estetyczny i prosty interfejs WPF

---

## 🖥️ Wygląd aplikacji

<img width="786" height="441" alt="image" src="https://github.com/user-attachments/assets/57832bd9-1858-4e50-b26e-d105858a7a03" />

---

## 🧠 Zasady gry

> Gra strategiczna rozgrywana przez dwóch graczy, najczęściej na kartce w kratkę.
> Gracze obejmują pola na przemian, dążąc do objęcia trzech pól w jednej linii, przy jednoczesnym uniemożliwieniu tego samego przeciwnikowi.

---

## ⚙️ Jak uruchomić projekt

1. Otwórz projekt w **Visual Studio (Community lub wyższej)**.
2. Upewnij się, że masz zainstalowane:

   * .NET Framework (np. 4.7.2 lub nowszy)
   * WPF (Windows Presentation Foundation)
3. Uruchom projekt (klawisz **F5**).
4. Gotowe — możesz grać! 🎉

---

## 📂 Struktura projektu

```
📁 kółko_i_krzyżyk/
 ├── MainWindow.xaml          → plik interfejsu WPF
 ├── MainWindow.xaml.cs       → logika aplikacji (C#)
 ├── App.xaml
 ├── App.xaml.cs
 ├── kółko_i_krzyżyk.csproj
 └── README.md
```

---

## 💡 Działanie gry

* Kliknięcie pola ustawia **X** lub **O** w zależności od gracza.
* Po każdym ruchu gra sprawdza, czy któryś z graczy wygrał lub czy nastąpił remis.
* Po zakończeniu rundy pojawia się komunikat i automatycznie resetuje planszę.
* Punkty są zliczane przez cały czas działania aplikacji.

---

## 🔧 Autor

Projekt stworzony przez **Maciej Strzelec**
📅 Rok: **Marzec 2025**
💻 Technologie: **C#, WPF, .NET**

---

## 📜 Licencja

Ten projekt jest udostępniony na licencji **MIT**.
Możesz swobodnie korzystać, modyfikować i udostępniać projekt z zachowaniem informacji o autorze.
