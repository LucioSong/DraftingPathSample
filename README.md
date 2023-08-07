# DraftingPathSample

3D 캐드 기반의 기본적인 Entity 생성 / 수정 / 삭제 등을 할 수 있는 샘플코드 입니다. Visual studio 2022 에서 작업하였으며, 프로젝트 내부 DraftingPathComponentDLL / DraftingPathComponentDLL_x64 폴더에 필요 DLL이 있습니다. Bit를 선택적으로 Build 할 때에는 참조에서 DraftingPathComponent.dll을 해당 폴더에서 선택 후 Build를 진행해야 합니다. 기본적으로 64bit로 구성되어 있으며, BuildEvent에 필요한 Dll은 빌드 후 복사되도록 구성되어 있습니다.

기본적으로 Evaluation version으로 되어 있습니다. USB Dongle 형태로 라이센스를 부여하는 방식으로 되어 있으니 아래 페이지에 방명록을 남겨주시면 Demo Dongle을 보내드리는 방식으로 하고자 합니다. 이용에 참고 부탁드립니다.

문의 사항은 https://luciodev.tistory.com/ 의 방명록에 남겨주세요~!



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
