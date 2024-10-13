using UnityEngine;
using Articy.Unity;
using Articy.Unity.Interfaces;
using TMPro;

public class BranchChoice : MonoBehaviour
{
    private Branch branch;
    private ArticyFlowPlayer flowPlayer;
    private ArticyObject Entity;
    [SerializeField]
    TMP_Text buttonText;
    public void AssignBranch(ArticyFlowPlayer aflowPlayer, Branch aBranch)
    {
        branch = aBranch;
        flowPlayer = aflowPlayer;
        IFlowObject target = aBranch.Target;
        buttonText.text = string.Empty;

        //check for the "menu text" in the Articy flow player
        var objectWithMenuText = target as IObjectWithMenuText;
        if (objectWithMenuText != null)
        {
            buttonText.text = objectWithMenuText.MenuText;
        }

        //trying without menu text
        //var objectWithText = target as IObjectWithLocalizableText;

        //if (objectWithText != null)
        //{
        //    buttonText.text = objectWithText.Text;
        //}

        //after that(or instead?) if there is no menu text
        //but want to display main text
        //if (string.IsNullOrEmpty(buttonText.text))
        //{
        //    var objectWithText = target as IObjectWithLocalizableText;
        //    if (objectWithText != null)
        //    {
        //        buttonText.text = objectWithText.Text;
        //    }
        //}

        //or if just want to display an arrow or next
        if (string.IsNullOrEmpty(buttonText.text))
        {
            buttonText.text = ">>>";
        }
    }

    public void OnBranchSelected()
    {
        flowPlayer.Play(branch); //without an argument flowPlayer.Play will choose first branch
    }
}
