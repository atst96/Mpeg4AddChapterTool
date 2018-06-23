# Mpeg4AddChapterTool
Mpeg4の動画ファイルにチャプター情報を追加するツールです。


## 概要
MP4ファイルに最大2形式のチャプター情報を書き込みます。事前にチャプター情報が記述されたテキストファイル（Nero形式またはApple形式）の準備が必要です。  
また、ソフトウェアの使用にあたっては、別途[MP4Box](https://gpac.wp.imt.fr/)のexeが必要です。


## 留意事項
- 本来MP4Boxでコマンドラインで行う作業をGUI化＆バッチ処理ができるようにしただけのものです。
- 各ファイルへのパスが英数字以外だったり、パスが長すぎたりすると、MP4BoxでI/Oエラーが発生し、正常に処理できない場合があります。
- Apple形式のチャプター情報において、チャプター情報として参照するファイルの拡張子が`*.txt`の場合、MP4Boxに未サポートのファイルとして扱われることがあります。その場合は、拡張子を`*.ttxt`に変更してください。
- Nero形式についてはMPC-HCで、Apple形式についてはiTunesで、映像のチャプターごとのスキップができることを確認しました。


## ライセンス
- Mpeg4AddChapterTool のソースコードはMITライセンスの下で配布しています。
- Mpeg4AddChapterTool では以下のライセンスが含まれたソフトウェアを使用しています。


### MessagePack
Copyright (c) 2017 Yoshifumi Kawai  
MIT License  
https://github.com/neuecc/MessagePack-CSharp/blob/master/LICENSE

### .NET Core Libraries (CoreFX)
Copyright (c) .NET Foundation and Contributors  
The MIT License (MIT)  
https://github.com/dotnet/corefx/blob/master/LICENSE.TXT
