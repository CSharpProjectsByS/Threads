# Threads

## Tu z kolei sprawdzamy poprawność zapisywania danych przez dwa wątki jeden zapisuje drugi odczytuje.

### Scenariusz jest następujący tworzymy klasę: która posiada 2 zmienne jedna typu int druga string. Za każdym razem gdy zapisujemy
###do tej klasy jakąś liczbę zapisujemy ją w tych dwóch polach (int, string).

### Jeden wątek zapisuje, drugi sprawdza poprawność.

### Należy wykonać 3 sprawdziany

1. Odpalamy wątki na pałę - jeden sobie zapisuje drugi sprawdza poprawność.
2. Używamy thread.sleep miedzy zapisem między polami.

```c#
        public void SaveSleep(int i)
        {
            NumberString = i.ToString();
            Thread.Sleep(0);
            NumberInt = i;
        }
```

3. W odpowiednie sposób używamy locka:

```c#
        public void SaveLock(int i, object locker)
        {
            lock (locker)
            {
                NumberString = i.ToString();
                NumberInt = i;
            }
        }
        
        public bool CheckCorrectLock(object locker)
        {
            bool correct = true;

            lock (locker)
            {
                if (NumberInt != Int32.Parse(NumberString))
                {
                    correct = false;
                }
            }

            return correct;
        }
```
Poprawność dla każdego sprawdzianu podajemy w procentach. Można tu utworzyć aplikację okienkową.
