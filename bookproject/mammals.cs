using ooppractice;

mammals myMammals= new mammals();
dog myDog = new dog();
cat myCat = new cat();
human Jeff = new human();


myMammal.Talk();



List<mammals> animalKingdom = new List<myMammals>();
animalKingdom.Add(myMammals);
animalKingdom.Add(myDog);
animalKingdom.Add(myCat);
animalKingdom.Add(Jeff);

foreach(mammals mammal in animalKingdom){
    mammal.Talk();
}