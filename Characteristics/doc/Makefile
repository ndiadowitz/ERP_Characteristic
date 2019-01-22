.PHONY: paper

PRE = 0-pre.md
PRO = 1-project.md
HEA = tex/header.tex
TIT = tex/title.tex
TYP = tex/type

REPORT = report
ARTICLE = article

paper:
	mkdir -p pdf
	ln -sf ../image pdf/
ifeq ($(shell cat ${TYP}), ${REPORT})
	make paper-report
endif
ifeq ($(shell cat ${TYP}), ${ARTICLE})
	make paper-article
endif	
	cd pdf && latexmk -pdf paper.tex
	cp pdf/paper.pdf paper.pdf

paper-report:
	~/.cabal/bin/pandoc \
		--toc \
		--filter ~/.cabal/bin/pandoc-crossref \
		--number-sections \
		-H tex/header.tex \
		-B tex/title.tex \
		-N \
		-V lang=de-DE \
		--highlight-style tango \
		--variable urlcolor=cyan \
		-o pdf/paper.tex \
		*.md

paper-article:
	~/.cabal/bin/pandoc \
		--filter ~/.cabal/bin/pandoc-crossref \
		-H tex/header.tex \
		-V lang=de-DE \
		--highlight-style tango \
		--variable urlcolor=cyan \
		-o pdf/paper.tex \
		*.md

init-report: build build-header-report
	echo ${REPORT} > ${TYP}
	sed -i 's/documentclass: .*/documentclass: scrreprt/' ${PRE}
	sed -i 's/toc: .*/toc: yes/' ${PRE}
	
init-article: build
	echo ${ARTICLE} > ${TYP}
	sed -i 's/documentclass: .*/documentclass: scrartcl/' ${PRE}
	sed -i 's/toc: .*/toc: no/' ${PRE}

add-headAndFoot:
	sed -i -n '/<\!-- headAndFootBegin -->/{p;:a;N;/<!-- headAndFootEnd -->/!ba; s/.*\n/\\pagestyle{fancy}\n\\fancyhf{}\n\\renewcommand{\\footrulewidth}{0.4pt}\n\\fancyhead[L]{<top left>}\n\\fancyhead[C]{<top center>}\n\\fancyhead[R]{<top right>}\n\\fancyfoot[L]{<bottom left>}\n\\fancyfoot[C]{<bottom center>}\n\\fancyfoot[R]{\\thepage}\n/};p' ${PRE}

remove-headAndFoot:
	sed -i '/<\!-- headAndFootBegin -->/,/<\!-- headAndFootEnd -->/ {/<!-- headAndFootBegin -->/n;/<\!-- headAndFootEnd -->/!d}' ${PRE}

build:
ifeq ("$(wildcard tex)", "")
	mkdir -p tex
endif
ifeq ("$(wildcard image)", "")
	mkdir -p image
endif
ifeq ("$(wildcard ${PRO})", "")
	touch ${PRO}
endif
	touch ${HEA}
	make build-header
ifeq ("$(wildcard ${TIT})", "")
	touch ${TIT}
	make build-title
endif
ifeq ("$(wildcard ${TYP})", "")
	touch ${TYP}
endif
ifeq ("$(wildcard ${PRE})", "")
	touch ${PRE}
	make build-pre
endif

build-pre:
	echo '---' > ${PRE}
	echo 'documentclass: scrartcl' >> ${PRE}
	echo 'classoption: toc=listof,index=totoc' >> ${PRE}
	echo 'fontsize: 11pt' >> ${PRE}
	echo 'sections: yes' >> ${PRE}
	echo 'toc: yes' >> ${PRE}
	echo 'lof: no' >> ${PRE}
	echo 'lot: no' >> ${PRE}
	echo 'loe: yes' >> ${PRE}
	echo 'cref: yes' >> ${PRE}
	echo 'listings: yes' >> ${PRE}
	echo '' >> ${PRE}
	echo 'date: \\today' >> ${PRE}
	echo '---' >> ${PRE}
	echo '\\pagenumbering{arabic}' >> ${PRE}
	echo '\\setcounter{page}{1}' >> ${PRE}
	echo '' >> ${PRE}
	echo '<!-- headAndFootBegin -->' >> ${PRE}
	echo '<!-- headAndFootEnd -->' >> ${PRE}




build-header:
	echo '\\usepackage{url}' > ${HEA}
	echo '\\usepackage{scrhack}' >> ${HEA}
	echo '\\usepackage[babel, german=quotes]{csquotes}' >> ${HEA}
	echo '\\usepackage{graphicx}' >> ${HEA}
	echo '\\usepackage{lmodern}' >> ${HEA}
	echo '\\usepackage{hyperref}' >> ${HEA}
	echo '\\usepackage{cleveref}' >> ${HEA}
	echo '\\usepackage[utf8]{luainputenc}' >> ${HEA}
	echo '\\usepackage[T1]{fontenc}' >> ${HEA}
	echo '\\usepackage{gentium}' >> ${HEA}
	echo '\\usepackage{inconsolata}' >> ${HEA}
	echo '\\usepackage{fancyhdr}' >> ${HEA}
	echo '\\usepackage{color}' >> ${HEA}
	echo '\\usepackage{wallpaper}' >> ${HEA}
	echo '\\usepackage{wasysym}' >> ${HEA}
	echo '\\usepackage{ifthen}' >> ${HEA}
	echo '\\usepackage{setspace}' >> ${HEA}
	echo '\\usepackage{amssymb}' >> ${HEA}
	echo '\\usepackage{pifont}' >> ${HEA}
	echo '\\usepackage{calc}' >> ${HEA}
	echo '\\usepackage{etoolbox}' >> ${HEA}
	echo '' >> ${HEA}
	echo '\\definecolor{red}{rgb}{0.76,0.09,0.1}' >> ${HEA}
	echo '\\definecolor{yellow}{rgb}{0.72,0.097,0.10}' >> ${HEA}
	echo '\\definecolor{blue}{rgb}{0.17,0.26,0.56}' >> ${HEA}
	echo '\\definecolor{grey}{rgb}{0.294,0.294,0.29}' >> ${HEA}
	echo '\\definecolor{darkgrey}{rgb}{0.10,0.10,0.10}' >> ${HEA}
	echo '\\definecolor{lightgrey}{rgb}{0.90,0.90,0.90}' >> ${HEA}
	echo '' >> ${HEA}
	echo '\\appto\\chapterheadstartvskip{%' >> ${HEA}
	echo '  \\vspace{-4.5em}' >> ${HEA}
	echo '  \\smash{\makebox[0pt]{%' >> ${HEA}
	echo '    \\textcolor{lightgrey}{%' >> ${HEA}
	echo '      \\usesizeofkomafont{chapter}\\rule[-2.5\ht\strutbox-\dp\strutbox]{2\paperwidth}{1.5\\baselineskip}%' >> ${HEA}
	echo '  }}}' >> ${HEA}
	echo '  \\smash{\makebox[0pt]{%' >> ${HEA}
	echo '    \\textcolor{grey}{%' >> ${HEA}
	echo '      \\hspace*{9cm}\usesizeofkomafont{chapter}\\rule[-2.18\ht\strutbox]{2\paperwidth}{0.04\\baselineskip}%' >> ${HEA}
	echo '  }}}' >> ${HEA}
	echo '}' >> ${HEA}
	
build-header-report:
	echo '' >> ${HEA}
	echo '\\renewcommand\\chapterformat{%' >> ${HEA}
	echo '  \\makebox[0pt][r]{\\textcolor{grey}{\Huge\\textsc{\\thechapter}}\ \\' >> ${HEA}
	echo '  \\textcolor{grey}{\smash{\\rule[-2\dp\strutbox]{1.5pt}{1.801\\baselineskip}}}}%' >> ${HEA}
	echo '  \\enskip%' >> ${HEA}
	echo '}' >> ${HEA}
	echo '' >> ${HEA}
	echo '\\addtokomafont{chapter}{\\bfseries\\color{grey}}' >> ${HEA}
	echo '\\addtokomafont{section}{\\color{grey}}' >> ${HEA}
	echo '\\addtokomafont{subsection}{\\color{grey}}' >> ${HEA}
	echo '\\addtokomafont{subsubsection}{\\color{grey}}' >> ${HEA}

build-title:
	echo '\\newpage' > ${TIT}
	echo '\\ClearWallPaper' >> ${TIT}
	echo '%\\titlehead{\\begin{flushright}\includegraphics[width=6cm]{/images/logo.pdf}\\end{flushright}\\vspace{2cm}}' >> ${TIT}
	echo '\\title{\Huge\\color{grey}<title>}' >> ${TIT}
	echo '\\subtitle{\large\\color{grey}<subtitle>}' >> ${TIT}
	echo '\\author{\small <author>}' >> ${TIT}
	echo '\\date{}' >> ${TIT}
	echo '\\color{darkgrey}' >> ${TIT}
	echo '\\maketitle' >> ${TIT}

clean:
	rm pdf -r

install:
	sudo apt update
	sudo apt install make latexmk texlive-latex-recommended texlive-fonts-recommended texlive-latex-extra texlive-fonts-extra texlive-luatex texlive-lang-german
	sudo apt install cabal-install
	cabal update
	cabal install pandoc happy pandoc-crossref
