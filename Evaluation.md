Evaluation finale du cours .NET � l'IUT Lyon 1
==============================================

Crit�res d'�valuation
---------------------

* Solution apport�e aux probl�mes pos�s dans le fichier Readme.md + r�ponses aux questions (� mettre dans le fichier ci-dessous)
* La qualit� des commits : granularit� fine et commentaires explicites du pourquoi (et non du quoi, i.e ne pas dire quels fichiers ont �t� modifi�s, c'est inutile, Git le dit d�j�)
* La qualit� du code : utiliser un nommage correct + R# donne des r�gles � respecter, il suffit de les corriger
* Les tests unitaires : expressivit� (le nommage tout particuli�rement), granularit� (i.e on teste une chose � la fois), rapidit� (i.e instantan�), couverture de code et ind�pendance (un test ne d�pend pas des autres)
* Le design du code : utiliser les pratiques vues en cours pour �viter de faire du code difficilement maintenable et �volutif (SOLID...)

ATTENTION: ne pas changer le nommage des projets, des classes et m�thodes donn�s (sauf sur les tests si vous voulez).

A LA FIN DU TP: pensez � pousser vos commits sur votre compte GitHub et envoyer votre d�p�t � mon adresse mail.

R�ponses aux questions pos�es
-----------------------------

Q1)
J'ai utiliser un dictionaire de fonction, en invocant la fonction que je cherche directement grace � la cl�e (+,-,*,/)
Q2)
J'utilise la logique d'encapsulation afin de rendre abtrait toutes les fonction que ma calculatrice pourait employer (et donc rajouter de la faciliter quant � l'ajout de nouvelle fonctionalit�s)
Q3)
Je r�alise de l'abastraction en transformant des op�rateur en dure tel que '+' etc... en methode que je d�finie moi m�me.
Q4)
Le trainer est trop limit�, car les questions son ecrit en dure dans le code et les reponse afficher dans la console.
Q5)

Q6)
 