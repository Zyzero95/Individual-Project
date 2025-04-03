import { AnimalInterface } from "@/app/Interfaces/animalinterface"
import Image from "next/image"

export interface AnimalData {
    data: AnimalInterface
}

export default function AnimalCard({ data }: AnimalData) {
  return (
    <section className="anicard-wrapper">
      <figure className="anicard-figure">
        <Image 
            src={data.image}
            alt={`Image depicting ${data.name} uploaded from Unsplash.`}
            fill={true}
            sizes="1000px"
            priority={true}
        />
      </figure>
    </section>
  )
}
