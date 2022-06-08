using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Reference] //Reference : Ŭ������ ���� ������ �����մϴ�.
public class Example : GameObj
{
	//SetDefault : �ν����Ϳ� ������Ʈ�� �̸� ä���ݴϴ�.
	[SetDefault] public SomeComponent Components1;
	[SetDefault] [SerializeField] SomeComponent Components2;
	[SetDefault(getChild = true)] public SomeComponent[] Components3;
	[SetDefault(getChild = false)] public List<SomeComponent> Components4;

	protected override void UpdateMethod() //UpdateMethod : �� �����Ӹ��� ����� �޼ҵ��Դϴ�.
	{
		Debug.Log(Ref<Example>.Ins.Components2); //Ref<T>.Ins�� �̿��Ͽ� �ν��Ͻ��� �����մϴ�.
	}
}
