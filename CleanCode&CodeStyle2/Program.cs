class Weapon
{
    private const int Discharge = 0;

    private int _shotBulletCount = 1;
    private int _bulletCount;

    public bool IsOutOfAmmo() => _bulletCount == Discharge;

    public void Shoot() => _bulletCount -= _shotBulletCount;
}

