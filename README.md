# Godot 项目上传步骤

每次修改代码后：

git add .

git commit -m "本次修改内容"

git push

查看状态：

git status

查看历史：

git log --oneline

第一次上传项目（你刚刚做的）
1. 创建 GitHub 仓库

例如：

Godot-Roguelike
2. 项目目录初始化 Git
git init
3. 添加文件
git add .
4. 提交
git commit -m "Initial commit"
5. 连接 GitHub 仓库
git remote add origin 仓库地址

例如：

git remote add origin https://github.com/lpscarf/Godot-Roguelike.git
6. 上传
git branch -M main
git push -u origin main