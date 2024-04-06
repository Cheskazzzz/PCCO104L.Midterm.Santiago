using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter fan speed (1, 2, or 3): ");
        int fanSpeed = ValidateFanSpeed();

        Console.Write("Oscilliate Fan? (Y/N): ");
        char oscillateOption = ValidateOscillateOption();

        int baseFanPower = 10;
        int fanPowerOutput = baseFanPower * fanSpeed;

        if (oscillateOption == 'Y') {
            OscilliateFan(fanPowerOutput);
        }
        else if (oscillateOption == 'N') {
            SteadyFan(fanPowerOutput);
        }
    }

    static int ValidateFanSpeed() {
        int fanSpeed;
        while (true) {
            if (int.TryParse(Console.ReadLine(), out fanSpeed) && (fanSpeed >= 1 && fanSpeed <= 3)) {
                return fanSpeed;
            }
            else {
                Console.Write("Invalid input. Please enter a valid fan speed (1, 2, or 3): ");
            }
        }
    }

    static char ValidateOscillateOption() {
        char oscillateOption;
        while (true) {
            if (char.TryParse(Console.ReadLine().ToUpper(), out oscillateOption) && (oscillateOption == 'Y' || oscillateOption == 'N')) {
                return oscillateOption;
            }
            else {
                Console.Write("Invalid input. Please enter Y or N: ");
            }
        }
    }

    static void OscilliateFan(int fanPowerOutput) {
        for (int i = 1; i <= fanPowerOutput; ++i) {
            for (int j = 1; j <= i; ++j) {
                Console.Write("~");
            }
            Console.WriteLine();
        }

        for (int i = fanPowerOutput - 1; i >= 1; --i) {
            for (int j = 1; j <= i; ++j) {
                Console.Write("~");
            }
            Console.WriteLine();
        }
    }

    static void SteadyFan(int fanPowerOutput) {
        for (int i = 1; i <= 10; ++i) {
            for (int j = 1; j <= fanPowerOutput; ++j) {
                Console.Write("~");
            }
            Console.WriteLine();
        }
    }
}
