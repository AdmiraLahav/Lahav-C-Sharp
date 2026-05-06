/// <summary>
/// probably will use in unity
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp129
{
    public class NPC
    {
        private double base_health;
        private double current_health;
        private double attack_damage;
        private double attack_speed;
        private int move_speed;
        private bool alive;
        public NPC(double hp,double atk_dmg,double atk_spd,int mvs)
        {
            if (hp<0)
            {
                this.current_health = 100.0;
                Console.WriteLine("HP lower than 0, setting default 100");
            }
            else
                this.current_health = hp;
            this.base_health = this.current_health;
            this.attack_speed = atk_spd;
            this.attack_damage = atk_dmg;
            this.move_speed = mvs;
            this.alive = true;
        }
        public void LowerHealth(double hp)
        {
            if (hp < 0)
            {
                Console.WriteLine("INVALID");
                return;
            }
            else if (this.current_health < 0||this.current_health-hp<0)
            {
                this.current_health = 0;
                this.alive = false;
            }
            else
            {
                this.current_health = this.current_health - hp;
            }
        }
        public void AddHealth(double hp)
        {
            if (hp < 0)
            {
                Console.WriteLine("INVALID");
                return;
            }
            else if (this.current_health + hp > this.base_health)
            {
                this.current_health = this.base_health;
            }
            else
            {
                this.current_health = this.current_health + hp;
            }
        }
        public double GetCurrentHealth()
        {
            return this.current_health;
        }
        public double GetBaseHealth()
        {
            return this.base_health;
        }
        public double GetAttackSpeed()
        {
            return this.attack_speed;
        }
        public double GetAttackDamage()
        {
            return this.attack_damage;
        }
        public double GetMoveSpeed()
        {
            return this.move_speed;
        }
        public bool GetStatus()
        {
            return this.alive;
        }
        public override string ToString()
        {
            return $"Base health: {base_health}\nCurrent health: {current_health}\nAttack speed: {attack_speed}\nAttack damage: {attack_damage}\nMove speed: {move_speed}\nIs alive: {alive}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NPC alex = new NPC(100, 10, 10, 10);
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (!char.IsControl(keyInfo.KeyChar)&&!char.IsWhiteSpace(keyInfo.KeyChar))
                {
                    Console.WriteLine(keyInfo.KeyChar);
                    if (keyInfo.KeyChar == 'a')
                    {
                        alex.LowerHealth(3);
                    }
                    else if (keyInfo.KeyChar == 'w')
                    {
                        alex.AddHealth(4);
                    }
                }
                else
                {
                    Console.WriteLine(keyInfo.Key);
                }
                Console.WriteLine(alex.ToString());
            }
        }
    }
}
