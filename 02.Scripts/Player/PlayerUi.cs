using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUi : MonoBehaviour {
	[SerializeField]
	private GameObject Energy;

    [SerializeField]
    private GameObject Health;

    [SerializeField]
    private GameObject winnerScreen;

    public GameObject backCamMask;

	public GameObject miniCamMask;

    public GameObject aimCircle;

    public GameObject[] invenBG;

    public GameObject[] Guns;

    [SerializeField]
    private PlayerStats playerStats;

    Image EnergyImage;
    Image HealthImage;

    void Update()
    {
        if (GameDirector.Instance.GetComponent<GameStart>().GetStart)
        {
            if (GameDirector.Instance.players.Count == 1 && !GameDirector.Instance.isPlayerDead)
            {
                winnerScreen.SetActive(true);
            }
        } 
    }

    private void Start()
	{
		EnergyImage = Energy.GetComponent<Image>();
        HealthImage = Health.GetComponent<Image>();
    }

	public void SetEnergy(float e)
    {
        EnergyImage.fillAmount = e / playerStats.EnergyMax;
    }

    public void SetHealth(float h)
    {
        HealthImage.fillAmount = h / playerStats.HealthMax;        
    }

    public void SetEnergyBar(float e)
    {
        EnergyImage.fillAmount = e / playerStats.EnergyMax;
    }

    public void SetHealthBar(float h)
    {
        HealthImage.fillAmount = h / playerStats.HealthMax;
    }
}
