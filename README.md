# VR-2020
Virtuelna Realnost 2020


# Домашна бр. 1

<br>

Домашната е сработена во Unity 2018.4.20f1 (64-bit). Мобилниот уред на кој што тестирам е Huawei P Smart+ (во некои делови од светот познат како Nova 3i).
Во однос на инсталацијата, се помагав со официјалната документација и потребните додатоци.

За основно снаоѓање во Unity ми помогнаа разни туторијали, додека од следниве научив конкретно како да се движам низ околината без input:	

https://www.youtube.com/watch?v=kBTn2pGwZUk&list=PLHQUlKGE3pvz5-8aDjy6pral6ash4-JKu&index=4

https://www.youtube.com/watch?v=ecYezSD4qPg

Во проектот е искористена комбинација на двата.
Движењето нанапред се одвива доколку главата (главната камера) ни е завртена барем 20 степени надолу, 
но не повеќе од 90 степени (гледано по Х оската). Изменета е брзината на движењето, како и висината на играчот. 
Пробав по истиот принцип да додадам движење наназад, но од некој причина не работеше, не успеав да најдам на интернет предлог кој ќе функционира кај мене. 

Сцената е комплетно мој дизајн, при што користев пакет со текстури и објекти од пустина, кој што го симнав од Asset Store.

![](screenshots/game1.jpg)
![](screenshots/game2.jpg)
![](screenshots/game3.jpg)

<br><br>

# Домашна бр. 2

<br> 

За интеракцијата со копче преку поглед ми помогна [следниот туторијал](https://www.youtube.com/watch?time_continue=12&v=zdNBZsJdg9c), додека [овој](https://www.youtube.com/watch?time_continue=10&v=zc8ac_qUXQY) ми даде основа за менито кое што го користам.


Интеракцијата е успешна доколку го задржиме погледот на посакуваното копче 2 секунди.

Во апликацијата се додадени 2 нови сцени: Menu и End. 
Започнуваме со Menu, каде што имаме опција да ја започнеме играта, да добиеме повеќе информации преку копчето Intro или пак да излеземе од играта со Quit. 

![](screenshots/menu.jpg)
![](screenshots/intro.jpg)

Во главната сцена можеме да се задржиме само 1 минута. По истекот на ова време апликацијата не носи до сцената End, каде што можеме повторно да започнеме со играта или пак конечно да излеземе од апликацијата.

![](screenshots/endMenu.jpg)

<br> <br>

*Извршните верзии од соодветните домашни (.apk) се наоѓаат во фолдерот builds.*

<br> <br>

***Драгана Николовска 161285***
