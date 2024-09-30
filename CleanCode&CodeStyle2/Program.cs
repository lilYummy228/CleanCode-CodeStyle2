using System;

public class Weapon
{
    private int _bulletCount;
    private int _shotCount;

    public Weapon(int bulletCount, int shotCount)
    {
        _bulletCount = bulletCount >= 0 ? bulletCount : throw new ArgumentOutOfRangeException($"{nameof(bulletCount)} cannot be less than zero");
        _shotCount = shotCount > 0 ? shotCount : throw new ArgumentOutOfRangeException($"{nameof(bulletCount)} cannot be less than or equal to zero");
    }

    public bool CanShoot => _bulletCount > 0 && _bulletCount >= _shotCount;

    public void Shoot()
    {
        if (CanShoot == false)
            throw new InvalidOperationException($"{nameof(_bulletCount)} is less than or equal to zero");

        _bulletCount -= _shotCount;
    }
}