# Praktycznie o Unity
Praktycznie o Unity - podstawowy projekt i pojęcia związane z programowaniem w Unity.

## Jak korzystać z tego repo

1. Ściągnąć do jakiegoś folderu u siebie (`git clone git@github.com:grastra-pl/praktycznieOUnity.git`)
![image](https://github.com/grastra-pl/praktycznieOUnity/assets/14235397/3d334795-a800-4fc0-81d0-10434d6ca839)

3. Dodać w Unity Hubie jako nowy projekt

## MonoBehaviour

Pytaliśmy Was o to na rozmowie rekrutacyjnej, nikt nie umiał udzielić poprawnej odpowiedzi, co to jest MonoBehaviour.

Oto odpowiedź, z jakiej bylibyśmy zadowoleni:

W Unity MonoBehaviour jest klasą bazową, która jest używana do tworzenia skryptów, które sterują zachowaniem obiektów w grze. MonoBehaviour jest częścią silnika Unity i jest kluczowym komponentem do tworzenia interaktywnych i dynamicznych elementów w środowisku Unity.

Nazwa "MonoBehaviour" w Unity jest zainspirowana strukturą programowania znaną jako "Mono" - platforma programistyczna opracowana przez Xamarin (obecnie część Microsoftu), która umożliwia pisanie aplikacji wieloplatformowych. W przypadku Unity, klasa MonoBehaviour została stworzona na podstawie tego podejścia programowania, aby umożliwić tworzenie skryptów, które są kompatybilne z platformami Unity.

MonoBehaviour sugeruje, że ta klasa działa jako podstawa dla skryptów, które mają "zachowanie" lub "reakcję" w odpowiedzi na różne wydarzenia w grze. Dzięki dziedziczeniu z klasy MonoBehaviour, skrypty mogą zawierać funkcje, które są automatycznie wywoływane przez silnik Unity w odpowiednich momentach, takich jak Start(), Update(), OnCollisionEnter(), itp.

Aby używać klasy MonoBehaviour w Unity, należy utworzyć skrypt w skrypcie C# i przypisać go do obiektu w hierarchii sceny lub utworzyć skrypt jako komponent dla obiektu w inspektorze. Następnie można zaimplementować funkcje takie jak Start(), Update(), OnCollisionEnter(), itp., w celu definiowania zachowania obiektu w zależności od potrzeb gry. Te funkcje będą automatycznie wywoływane przez silnik Unity w odpowiednich momentach.

Dzięki użyciu klasy MonoBehaviour można kontrolować ruch postaci, interakcję z użytkownikiem, animacje, kolizje, dźwięki i wiele innych aspektów gry. Jest to podstawowy element programowania w Unity, umożliwiający tworzenie dynamicznych i interaktywnych środowisk gier.







