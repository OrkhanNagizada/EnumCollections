using EnumCollections.Helpers;
using EnumCollections;

List<Weapon> weapons = new List<Weapon>();

while (true)
{
    Console.WriteLine("Zehmet olmasa secim edin:");
    Console.WriteLine("1. Silah elave et");
    Console.WriteLine("2. Silahi doldur");
    Console.WriteLine("3. Silahdan atesh et");
    Console.WriteLine("4. Silahın atəshini ac");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Silah tipini seC (1: Normal, 2: Armor, 3: MM20):");
            int typeChoice = int.Parse(Console.ReadLine());
            BulletType bulletType = BulletType.Normal;
            if (typeChoice == 2)
                bulletType = BulletType.Armor;
            else if (typeChoice == 3)
                bulletType = BulletType.MM20;

            Console.WriteLine("Maksimum gUlle sayini daxil et:");
            int maxBullets = int.Parse(Console.ReadLine());

            Weapon newWeapon = new Weapon(bulletType, maxBullets);
            weapons.Add(newWeapon);
            Console.WriteLine($"Yeni silah əlavə olundu. Silah ID: {newWeapon.Id}");
            break;

        case "2":
            Console.WriteLine("Silah ID-ni daxil edin:");
            int fillId = int.Parse(Console.ReadLine());
            Weapon fillWeapon = weapons.Find(w => w.Id == fillId);
            if (fillWeapon != null)
            {
                Console.WriteLine("Doldurmaq ucun gulle sayını daxil edin:");
                int numBullets = int.Parse(Console.ReadLine());
                fillWeapon.Fill(numBullets);
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz ID ilə silah tapılmadı.");
            }
            break;

        case "3":
            Console.WriteLine("Silah ID-ni daxil edin:");
            int fireId = int.Parse(Console.ReadLine());
            Weapon fireWeapon = weapons.Find(w => w.Id == fireId);
            if (fireWeapon != null)
            {
                fireWeapon.Fire();
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz ID li silah tapilmadi.");
            }
            break;

        case "4":
            Console.WriteLine("Silah ID-ni daxil edin:");
            int pullTriggerId = int.Parse(Console.ReadLine());
            Weapon pullTriggerWeapon = weapons.Find(w => w.Id == pullTriggerId);
            if (pullTriggerWeapon != null)
            {
                pullTriggerWeapon.PullTrigger();
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz ID li silah tapilmadi.");
            }
            break;

        default:
            Console.WriteLine("Duzgun bir secim et.");
            break;
    }

    Console.WriteLine("Davam etmek ucun secim et , cixmaq üçün 'E' daxil et.");
    string continueChoice = Console.ReadLine();
    if (continueChoice.ToLower() == "E")
        break;
}
    
