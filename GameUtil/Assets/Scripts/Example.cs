using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Reference] //Reference : Ŭ������ �ν��Ͻ��� �����մϴ�.
public class Example : GameObj
{
	[SetDefault] //SetDefult : �ν����Ϳ��� ������Ʈ�� �⺻���� �־��ݴϴ�.
	[SerializeField] SomeComponent Components1;
	[SetDefault] public SomeComponent Components2;
	[SetDefault] public SomeComponent[] Components3;
	[SetDefault] public List<SomeComponent> Components4;

	protected override void UpdateMethod() //UpdateMethod : �� �����Ӹ��� ����� �޼ҵ��Դϴ�.
	{
		Debug.Log(Ref<Example>.Ins.Components2); //Ref<T>.Ins�� �̿��Ͽ� �ν��Ͻ��� �����մϴ�.
	}
}
