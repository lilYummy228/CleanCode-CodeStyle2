using System;

public class Weapon
{
    private const int Discharge = 0;

    private int _bulletCount;

    public Weapon(int bulletCount) =>
        _bulletCount = bulletCount;

    public bool CanShoot => 
        _bulletCount > Discharge;

    public void Shoot()
    {
        if (CanShoot == false)
            throw new InvalidOperationException($"{nameof(_bulletCount)} is less than or equal to zero");   

        _bulletCount--;
    }
}