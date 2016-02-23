#install.packages("tuneR")
#install.packages("signal")
#library(tuneR)
#library(dtw)
#library(signal)

rows <- read.csv("C:/Temp/Обучающая выборка/KVA_27-05-2015_16-56-40_300_46586760440_1000hz_int16_I.row")
wav <- readWave("C:/Temp/Обучающая выборка/KVA_27-05-2015_16-56-40_300_46586760440_1000hz_int16_I.wav")


plot(wav@left[rows[102,]:rows[103,]], type ="l")

length(wav@left[rows[102,]:rows[103,]])
length(wav@left[rows[101,]:rows[102,]])
length(wav@left[rows[103,]:rows[104,]])

# lpc
pspectrum <- powspec(wav@left[rows[203,]:rows[204,]], sr=1000, wintime = 120, steptime = 120)
aspectrum <- audspec(pspectrum)$aspectrum
lpcas <- dolpc(aspectrum, 16)
plot(lpcas)

#dtw
d1 <- wav@left[rows[101,]:rows[102,]]
d2 <- wav@left[rows[301,]:rows[302,]]
par(mfrow=c(3,1));
plot(d1, type ="l")
plot(d2, type ="l")

d3 <- dtw(d1, d2)
alignment<-dtw(d2,d1,step=asymmetric)
wt<-warp(alignment,index.reference=FALSE);
plot(d2[wt], type ="l")

#dtw to lpc
pspectrum <- powspec(d1, sr=1000)
aspectrum <- audspec(pspectrum)$aspectrum
lpcas <- dolpc(aspectrum, 2)
par(mfrow=c(2,1));
plot(lpcas)
pspectrum <- powspec(d2, sr=1000)
aspectrum <- audspec(pspectrum)$aspectrum
lpcas <- dolpc(aspectrum, 2)
plot(lpcas )

#specgramm
png(filename="C:/Temp/Обучающая выборка/KVA_27-05-2015_16-56-40_300_46586760440_1000hz_int16_I.png")
  #par(mfrow=c(2,1));
  X.k <- fft(d1)
  plot.frequency.spectrum(X.k, xlimits=c(0,50))
  #X.k <- fft(d2[wt])
  #plot.frequency.spectrum(X.k, xlimits=c(0,50))
dev.off()


plot.frequency.spectrum <- function(X.k, xlimits=c(0,length(X.k))) {
  plot.data  <- cbind(0:(length(X.k)-1), Mod(X.k))

  # TODO: why this scaling is necessary?
  plot.data[2:length(X.k),2] <- 2*plot.data[2:length(X.k),2]

  plot(plot.data, t="h", lwd=2, main="",
       xlab="Frequency (Hz)", ylab="Strength",
       xlim=xlimits, ylim=c(0,max(Mod(plot.data[,2]))))
}