using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    //public Sprite

    public CharacterBehaviour Player1;
    public CharacterBehaviour Player2;

    public GameObject Game;

    public GameObject FlashingPanel;

    public Sprite[] Weapons;

    public GameObject DamageScreen;
    public Animator DamageScreenAnimator;
    public GameObject Weapon;

    public GameObject WinnerScreen;
    public Image Winner;

    public AudioSource BackgroundMusic;
    public AudioSource Effects;

    public AudioClip KatanaClip;
    public AudioClip ArrowClip;
    public AudioClip BackgroundClip;
    public AudioClip WinClip;


    int round;

    // Start is called before the first frame update
    void Awake()
    {
        if (_instance != null && _instance != this)
            Destroy(this.gameObject);
        else
            _instance = this;

        round = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1.Attacked && Player2.Attacked)
        {
            StartCoroutine("ShowFlashPanel");
            string result = (Player1.GetLastAttackValue() < Player2.GetLastAttackValue()) ? "Player 1 Wins" : "Player 2 Wins";
            Debug.Log($"{result}");
            Player1.Attacked = false;
            Player2.Attacked = false;

        }
    }

    IEnumerator ShowFlashPanel()
    {
        int damage = 5;
        if (Player1.GetLastAttackValue() < Player2.GetLastAttackValue())
        {
            Player2.TakeDamage();
            damage -= Player2.Health;
            Weapon.GetComponent<Image>().sprite = Weapons[(int)Player1.GetWeapon()];
            DamageScreen.transform.localScale = new Vector3(-1, DamageScreen.transform.localScale.y, DamageScreen.transform.localScale.z);
            Winner.sprite = Player1.Renderer.sprite;

            Effects.clip = KatanaClip;
        }
        else
        {
            DamageScreen.transform.localScale = new Vector3(1, DamageScreen.transform.localScale.y, DamageScreen.transform.localScale.z);
            Player1.TakeDamage();
            damage -= Player1.Health;
            Weapon.GetComponent<Image>().sprite = Weapons[(int)Player2.GetWeapon()];
            Winner.sprite = Player2.Renderer.sprite;

            Effects.clip = ArrowClip;
        }

        BackgroundMusic.Pause();

        FlashingPanel.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        FlashingPanel.GetComponent<Image>().color = Color.black;
        //FlashingPanel.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        //FlashingPanel.SetActive(true);
        FlashingPanel.GetComponent<Image>().color = Color.white;

        yield return new WaitForSeconds(0.1f);
        FlashingPanel.SetActive(false);
        yield return new WaitForSeconds(0.1f);

        DamageScreen.SetActive(true);
        DamageScreenAnimator.SetInteger("Damage", damage);
        
        Effects.Play();



    }
    public void NewRound()
    {
        round++;
        DamageScreenAnimator.SetInteger("Damage", 0);
        DamageScreen.SetActive(false);
        Player1.Reload();
        Player2.Reload();
        Weapon.transform.position = new Vector3(747, Weapon.transform.position.y, Weapon.transform.position.z);

        BackgroundMusic.Play();


    }

    public void GameOver()
    {
        BackgroundMusic.clip = WinClip;
        BackgroundMusic.Play();
        Game.SetActive(false);
        WinnerScreen.SetActive(true);
        DamageScreen.SetActive(false);
        DamageScreenAnimator.SetInteger("Damage", 0);
    }

    public void NewGame()
    {
        round = 0;

        Player1.Health = 5;
        Player2.Health = 5;

        Game.SetActive(true);
        WinnerScreen.SetActive(false);

        BackgroundMusic.clip = BackgroundClip;
        BackgroundMusic.Play();

        NewRound();
    }

    private void OnQuit()
    {
        Application.Quit();
    }
}


public enum WeaponEnum
{
    Katana = 0,
    Arrow = 1
}

public enum CharacterEnum
{
    Samurai = 0,
    Amazon = 1
}

public enum WoundEnum
{
    Superficial,
    Severe,
    Deadly
}
