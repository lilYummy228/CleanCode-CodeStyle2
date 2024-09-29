class Weapon
{
    private const int Discharge = 0;
    private const int ShotBulletsCount = 1;

    private int _bulletCount;

    public bool IsOutOfAmmo() => _bulletCount == Discharge;

    public void Shoot()
    {
        if (IsOutOfAmmo() == false)
            _bulletCount -= ShotBulletsCount;
    }
}

