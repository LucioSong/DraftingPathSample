# DraftingPathSample

3D 캐드 기반의 기본적인 Entity 생성 / 수정 / 삭제 등을 할 수 있는 샘플코드 입니다. Visual studio 2022 에서 작업하였으며, 프로젝트 내부 DraftingPathComponentDLL / DraftingPathComponentDLL_x64 폴더에 필요 DLL이 있습니다. Bit를 선택적으로 Build 할 때에는 참조에서 DraftingPathComponent.dll을 해당 폴더에서 선택 후 참조의 DraftingPathComponent의 속성에서 로컬복사를 "False"로 세팅한 후 각 폴에서 해당 실행파일로 복사한 후 실행해야 합니다. 기본적으로 64bit로 구성되어 있으며, BuildEvent에 필요한 Dll은 빌드 후 복사되도록 구성되어 있습니다.

Bit에 맞는 Build 시 아래와 같이 해야 합니다.

1. 참조를 해당 폴더에서 추가

![Cap 2023-02-06 13-11-36-543](https://user-images.githubusercontent.com/122073722/216887810-2e0e2860-9f3e-441e-b3ff-2b69dac8e480.png)

2. 참조의 DraftingPathComponent 속성에서 로컬복사를 "False"로 선택

![Cap 2023-02-06 14-04-53-308](https://user-images.githubusercontent.com/122073722/216888080-45c31018-7f1c-4590-907c-fcad31046fbc.png)


- 실행 이미지
![image](https://user-images.githubusercontent.com/122073722/216888476-0b73c660-81c8-4d85-9dcf-84819841251f.png)


- Summary 코드
```CSharp
public partial class Form1 : Form
{
    DraftingViewport viewport = null;

    //...

    private void Form1_Load(object sender, EventArgs e)
    {
        viewport = new DraftingViewport();
        viewport.Dock = DockStyle.Fill;
        panel1.Controls.Add(viewport);

        propertyGrid1.SelectedObject = viewport;

        viewport.EntiesSelectionChange += Viewport_EntiesSelectionChange;
    }

    private void Viewport_EntiesSelectionChange(object sender, EventArgs e)
    {
        List<int> selection = sender as List<int>;
        if (selection != null && selection.Count > 0)
        {
            int selInd = selection[0];

            propertyGrid2.SelectedObject = viewport.GetEditEntity(selInd);
        }
        else
        {
            propertyGrid2.SelectedObject = null;
        }
    }

    //...
}
```

문의 사항은 https://luciodev.tistory.com/ 의 방명록에 남겨주세요~!
