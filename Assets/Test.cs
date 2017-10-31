using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 魔法使いクラス
/// </summary>
public class Magician
{
	#region プロパティ
	/// <summary>
	/// MP
	/// </summary>
	private int m_MP = 53;
	#endregion

	/// <summary>
	/// 魔法を使用する
	/// </summary>
	/// <returns>使用できたかどうか</returns>
	public bool Magic()
	{
		if (m_MP >= 5)
		{
			m_MP -= 5;
			Debug.Log("魔法攻撃をした。残りMPは" + m_MP + "。");
			return true;
		}
		else
		{
			Debug.Log("MPが足りないため魔法が使えない。");
			return false;
		}
	}
}

/// <summary>
/// テストクラス
/// </summary>
public class Test : MonoBehaviour {
	private Magician m_Magician;

	void Start ()
	{
		m_Magician = new Magician();
		while (true)
		{
			if (!m_Magician.Magic())
				break;
		}
	}
	
	void Update ()
	{
		
	}
}
