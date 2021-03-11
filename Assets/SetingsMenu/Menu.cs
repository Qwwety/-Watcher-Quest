using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour
{
	public Dropdown resDropdown; // выпадающая менюшка
	public int minHeight = 720; // фильтр разрешения экрана по высоте, включая это
	public Button applyButton; // кнопка "Применить"
	public Toggle fullscreenToggle; // переключатель полноэкранный/оконный режим

	private Resolution[] resolutionsList;
	private int resolutionsList_id;

	void Start()
	{
		resolutionsList = Screen.resolutions;
		ReBuildResolutionsList();
		SetDropdownMenu();
		fullscreenToggle.isOn = Screen.fullScreen;
		applyButton.interactable = false;
	}

	string ResToString(Resolution res)
	{
		return res.width + " x " + res.height;
	}

	void SetDropdownMenu()
	{
		resDropdown.options = new System.Collections.Generic.List<Dropdown.OptionData>();

		for (int i = 0; i < resolutionsList.Length; i++)
		{
			Dropdown.OptionData option = new Dropdown.OptionData();
			option.text = ResToString(resolutionsList[i]);
			resDropdown.options.Add(option);
			if (resolutionsList[i].height == Screen.height && resolutionsList[i].width == Screen.width) resolutionsList_id = i;
		}

		resDropdown.value = resolutionsList_id;
		resDropdown.onValueChanged.AddListener(delegate { SetID(); });
		fullscreenToggle.onValueChanged.AddListener(delegate { SetID(); });
		applyButton.onClick.AddListener(() => { ApplyResolution(); });
	}

	void SetID()
	{
		applyButton.interactable = true;
		resolutionsList_id = resDropdown.value;
	}

	void ApplyResolution()
	{
		applyButton.interactable = false;
		Screen.SetResolution(resolutionsList[resolutionsList_id].width, resolutionsList[resolutionsList_id].height, fullscreenToggle.isOn);
	}

	void ReBuildResolutionsList()
	{
		int x = 0;
		foreach (Resolution element in resolutionsList)
		{
			if (element.height >= minHeight) x++;
		}
		Resolution[] pureArray = new Resolution[x];
		x = 0;
		foreach (Resolution element in resolutionsList)
		{
			if (element.height >= minHeight)
			{
				pureArray[x] = element;
				x++;
			}
		}
		resolutionsList = new Resolution[pureArray.Length];
		for (int i = 0; i < resolutionsList.Length; i++)
		{
			resolutionsList[i] = pureArray[i];
		}
	}
}
