# Git

## 一.初始化

```git
$ git config --list --show-origin		--查看所有的配置及它们所在的文件
$ git config --global user.name "ZMJ"	--用户信息
$ git config --global user.email "2427474674@qq.com"
$ git config --global core.editor emacs	--设置文本编辑器
$ git config --list					    --配置列表
$ git help config					    --得到命令手册
$ git add -h 						    --得到可选项的快速参考
```

## 二.Git基础

### 2.1	工作区、暂存区、版本库

![img](https://www.runoob.com/wp-content/uploads/2015/02/1352126739_7909.jpg)

### 2.2	创建版本库

```git
$ git init									 	--初始化仓库
$ git add readme.txt						 	--将文件添加到暂存区
$ git commit -m "wrote a readme file"			--提交文件到版本库 
git clone git@github.com:fsliurujie/test.git 	--SSH协议
git clone git://github.com/fsliurujie/test.git	--GIT协议
git clone https://github.com/fsliurujie/test.git--HTTPS协议
$ git status                                    --查看有仓库当前状态和有变更的文件

```

### 2.3 	版本回退

```git
--本地代码库回滚:只要将reset
$ git log --pretty=oneline	 --版本记录
$ git reset HEAD^            --回退所有内容到上一个版本 
$ git reset HEAD^ hello.txt  --回退 hello.txt 文件的版本到上一个版本  
$ git  reset  052e           --回退到指定版本 commit id
$ git reset --hard HEAD		 --hard 参数撤销工作区中所有未提交的修改内容，将暂存区与工作区都回到上一次版本，并删除之前的所有信息提交：

--远程分支回滚：先将本地分支回退，删除远程分支，重新push
$ git reset --hard HEAD~1
$ git push  -f origin master

```

### 2.4	修改和删除

```git
$ git checkout --file			--暂存区全部或指定的文件替换工作区的文件
$ git rm --cached <file>		--暂存区删除文件，工作区不变
$ git rm <file>				    --删除工作区和缓存区		
$ git diff					   	--暂存区和工作区的区别
$ git diff --cached	 			--暂存区和版本库区别
$ git diff --staged
$ git diff HEAD      			--工作区和版本库的区别
```

## 三.	远程仓库

![img](https://www.runoob.com/wp-content/uploads/2015/02/git-command.jpg)

```git
$ cat readme.txt	--读取文件内容
$ git remote -v		--显示所有远程仓库
$ git remote add origin git@github.git		--添加远程仓库
$ git push -u origin master	--推送向远程仓库
$ git remote rm name		--删除远程仓库
$ git remote rename old_name new_name		--修改仓库名
```

## 四.	分支管理

```git
$ git branch		--查看分支
$ git branch <name>	 --创建分支
$ git checkout <name> --切换分支
$ git switch <name>	  
$ git switch -c <name>--创建+切换分支
$ git merge <name>    --合并某分支到当前分支
$ git branch -d <name>--删除分支

```

## 五.	常见问题解决

### 5.1	fatal: refusing to merge unrelated histories

```git
  出现这个问题的最主要原因还是在于本地仓库和远程仓库实际上是独立的两个仓库。假如我之前是直接clone的方式在本地建立起远程github仓库的克隆本地仓库就不会有这问题了
  $git pull origin master --allow-unrelated-histories
```

