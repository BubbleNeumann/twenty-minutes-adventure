->main
===main===
Вы зашли в квартиру. В гостиной на полу вы видите труп молодой девушки, скорее всего хозяйки квартиры. #speaker:...

*[осмотреть труп]->corpse
*[осмотреть помещение]->livingRoom
*[опросить  свидетеля]->witnesses

->END

===corpse===
Она лежит на боку, головой к небольшому столу. Светлые волосы перепачканы в крови. Предположительно, причина смерти - удар об угол стола и как следствие, черепно-мозговая травма. 
*[приподнять голову и осмотреть место удара]
*[осмотреть открытые участки тела на предмет следов борьбы]
- На голове жертвы глубокая рана. Вы думаете, что надо будет уточнить у медиков, могла ли она привести к мгновенной смерти. 
Однако, других следов борьбы нет. Никаких синяков или порезов...
Внезапно, вы замечаете браслет на руке жертвы.
*[Снять браслет в качестве вещественного доказательства]
*[Внимательнее рассмотреть]
-Браслет дорогой. Странно, что убийца не снял его, после того, напал на девушку...
Осмотр тела закончен. Вы даёте работать эксператам и уходите к свидетельнице.
->witnesses
->DONE

===livingRoom===
Рядом с ней лежат две чайные чашки, скорее всего они упали со стола, когда она споткнулась об него. На полу разлит чай, но следов борьбы не видно.
*[поднять обе чашки и положить в пакет, чтобы потом отдать криминалистам для снятия отпечатков]
*[оставить все чашки на месте]
- На чашках могут остаться отпечатки... Раз чашки было две, значит жертва была знакома с убийцей...
Вы думаете, что скорее всего здесь произошла ссора, во время которой девушка споткнулась или ее толкнул преступник, и она ударилась головой об стол.
*[осмотреть труп]->corpse
*[уйти из гостиной и опросить свидетельницу]->witnesses
->DONE

===witnesses===
Вы подошли к женщине, которая вызвала полицию и видела предполагаемого преступника. 
->DONE

