using System.Collections.Generic;
using Game8.Sceny;
using System;
using System.Diagnostics;
using Game8.Flagi;

namespace Game8
{
    [System.Flags]
    public enum EnumFlagaSceny
    {
        Flaga, ShowGameMainMenuScene, ShowGameScene, ShowGameOverScene,
        ShowOpisScene, ShowWynikiScene, ShowGameLevel1Scene, ShowGameLevel2Scene, ShowGameLevel3Scene,
        ShowGameLevel4Scene, ShowGameLevel5Scene, ShowGameLevel6Scene,
        ShowGameLevel7Scene, ShowGameInterfejsScene
    }

    class GameState
    { 
        public static bool _IsFlagiSceny { get; set; }
        public static bool _IsFlagiScenyPoziomow { get; set; }

        public static bool IsFlagiSceny  { get { return _IsFlagiSceny; } set { if (value == true) _IsFlagiSceny = value; _IsFlagiScenyPoziomow = false; } }
        public static bool IsFlagiScenyPoziomow { get { return _IsFlagiScenyPoziomow; } set { if (value == true) _IsFlagiSceny = false; _IsFlagiScenyPoziomow = value; } }

        public GameState()
        {
            //
        }
        //IList<int> intList = new List<int>() { 10, 20, 30, 40 };
        //Or
        //IList<Student> studentList = new List<Student>() {
        //new Student() { StudentID = 1, StudentName = "Bill"} }

        /// <summary>
        /// Funkcja zwroci Index Flagi szukanej ktora zawiera podaną nazwe do funkcji ze wszystkich tablic /FlagiSceny, FlagiPoziomy
        /// </summary>
        /// <param name="nazwaFlagi">Nazwa Flagi -typu string ktorej chcemy znalesc Index .</param>
        public static int FindFlaga(string nazwaFlagi)
        {
            if ((Scena.Sceny.FindIndex(x => x.nazwa.Contains(nazwaFlagi)) != -1))
            {
                IsFlagiSceny = true;
                Scena.IndexSzukanejScenyPoziomy = -1;
                return Scena.IndexSzukanejSceny = Scena.Sceny.FindIndex(x => x.nazwa.Contains(nazwaFlagi));
            }
            else if ((Scena.ScenyPoziomow.FindIndex(x => x.nazwa.Contains(nazwaFlagi)) != -1))
            {
                IsFlagiScenyPoziomow = true;
                Scena.IndexSzukanejSceny = -1;
                return Scena.IndexSzukanejScenyPoziomy = Scena.ScenyPoziomow.FindIndex(x => x.nazwa.Contains(nazwaFlagi));
            }
            return -1;
        }

        /// <summary>
        /// Funkcja zwroci Index Flagi szukanej ktora zawiera podany Enum do funkcji ze wszystkich tablic /FlagiSceny, FlagiPoziomy
        /// </summary>
        /// <param name="nazwaFlagi">Nazwa Flagi -typu string ktorej chcemy znalesc Index .</param>
        public static int FindFlaga(EnumFlagaSceny enumFlagaSceny)
        {
            if ((Scena.Sceny.FindIndex(x => x.flagaSceny.nazwaEnumSceny == enumFlagaSceny) != -1))
            {
                IsFlagiSceny = true;
                Scena.IndexSzukanejScenyPoziomy= -1;
                return Scena.IndexSzukanejSceny = Scena.Sceny.FindIndex(x => x.flagaSceny.nazwaEnumSceny == enumFlagaSceny);
            }
            else if ((Scena.ScenyPoziomow.FindIndex(x => x.flagaScenyPoziomow.nazwaEnumSceny == enumFlagaSceny) != -1))
            {
                IsFlagiScenyPoziomow = true;
                Scena.IndexSzukanejSceny = -1;
                return Scena.IndexSzukanejScenyPoziomy = Scena.ScenyPoziomow.FindIndex(x => x.flagaScenyPoziomow.nazwaEnumSceny == enumFlagaSceny);
            }
            return -1;
        }

    }
}