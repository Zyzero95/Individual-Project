import { AnimalInterface } from "@/app/Interfaces/animalinterface"
import styles from "./animalidcard.module.css"
import anicardStyle from "./animalcard.module.css"
import Image from "next/image"


export interface AnimalData {
    data: AnimalInterface
}

export default function AnimalIdCard({ data }: AnimalData) {
  return (
    <section className={styles.idWrapper}>
        <figure className={styles.idFig}>
          <Image 
            src={data?.image}
            alt={`Image depicting ${data?.name}. Image from Unsplash`}
            fill={true}
            sizes="1000px"
            priority={true}
          />
        </figure> 
        <section className={styles.idInfoWrapper}>
          <h2 className={styles.idName}>{data?.name}</h2>
          <section className={anicardStyle.anicardEnvSection}>
            {data?.environment.map((env) => <p key={env} className={`${anicardStyle.anicardEnv}${env}`}>{env == "CoralReef" ? "Coral Reef" : env == "DeepOcean" ? "Deep Ocean" : env == "RockyReefs" ? "Rocky Reefs": env}</p>)}
          </section>
          <p>{data?.species}</p>
          <p>{data?.foodPreference}</p>
        </section>
        <section className={styles.idDescWrapper}>
            <h3 className={styles.idDescHeading}>Description: </h3>
            <p className={styles.idDesc}>{data?.description}</p>
        </section>
        </section>
  )
}
