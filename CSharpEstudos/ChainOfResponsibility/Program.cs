using ChainOfResponsibility;

var gerenteProjeto = new GerenteProjeto();
var supervisorEquipe = new SupervisorEquipe();
var setorRh = new SetorRh();

gerenteProjeto.ProximoAutorizador(supervisorEquipe);
supervisorEquipe.ProximoAutorizador(setorRh);

gerenteProjeto.AutorizarLicenca("João", 9);
gerenteProjeto.AutorizarLicenca("Pedro", 14);
gerenteProjeto.AutorizarLicenca("Bento", 18);
gerenteProjeto.AutorizarLicenca("Yoshi", 30);
gerenteProjeto.AutorizarLicenca("Jucemie", 50);